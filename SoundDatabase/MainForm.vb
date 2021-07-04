Imports System.IO
Imports System.Data.SqlClient

Public Class MainForm

#Region " Private Members "

    Private _LastFolder As String

#End Region

#Region " Form Event Handlers "

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.LastFolder = _LastFolder
        My.Settings.Save()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        Application.DoEvents()
        My.Settings.Reload()
        _LastFolder = My.Settings.LastFolder
        Try
            Me.SoundsTableAdapter.Fill(Me.SoundDBDataSet.Sounds)
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Microsoft SQL Server 2008 R2 required. " & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

#End Region

#Region " Button Event Handlers "

    Private Sub ButtonClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearAll.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear ALL entries?", My.Application.Info.Title, _
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Enabled = False
                SoundsBindingSource.MoveFirst()
                SoundsBindingSource.RemoveCurrent()
                For i As Integer = 0 To SoundsBindingSource.Count - 1
                    SoundsBindingSource.MoveNext()
                    SoundsBindingSource.RemoveCurrent()
                    Application.DoEvents()
                Next
                Me.Validate()
                Me.SoundsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SoundDBDataSet)
                Me.Enabled = True
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonSearch.Click
        Select Case ComboBoxSearchType.Text
            Case "Title"
                Me.SoundsBindingSource.Filter = "Title like '%" & TextBoxSearch.Text & "%'"
            Case "Description"
                Me.SoundsBindingSource.Filter = "Description like '%" & TextBoxSearch.Text & "%'"
            Case "Category"
                Me.SoundsBindingSource.Filter = "Category like '%" & TextBoxSearch.Text & "%'"
            Case "Tags"
                Me.SoundsBindingSource.Filter = "Tags like '%" & TextBoxSearch.Text & "%'"
            Case "Comment"
                Me.SoundsBindingSource.Filter = "Comment like '%" & TextBoxSearch.Text & "%'"
            Case Else
                Me.SoundsBindingSource.Filter = "Titles like '%*%'"
        End Select
    End Sub

    Private Sub ButtonClearSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearSearch.Click
        Me.SoundsBindingSource.Filter = "Title like '%*%'"
        Me.TextBoxSearch.Text = ""
    End Sub

    Private Sub ButtonFullPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFullPath.Click
        With OpenFileDialog1
            If String.IsNullOrEmpty(_LastFolder) Then
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
            Else
                .InitialDirectory = _LastFolder
            End If
            .Filter = "WAV Files (*.wav)|*.wav"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                FullPathTextBox.Text = .FileName
                _LastFolder = Path.GetDirectoryName(.FileName)
            End If
        End With
    End Sub

    Private Sub ButtonAddFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddFolder.Click
        Dim folder As String = ""
        With FolderBrowserDialog1
            .Description = "Browse for folder containing .WAV files to be added to database."
            If String.IsNullOrEmpty(_LastFolder) Then
                .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
            Else
                .SelectedPath = _LastFolder
            End If
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Enabled = False
                folder = .SelectedPath
                _LastFolder = .SelectedPath
                Dim di As DirectoryInfo = New DirectoryInfo(folder)
                For Each wavFile As FileInfo In di.GetFiles
                    If wavFile.Extension.ToLower = ".wav" Then
                        Me.SoundsBindingSource.AddNew()
                        Application.DoEvents()
                        FullPathTextBox.Text = wavFile.FullName
                        TitleTextBox.Text = Path.GetFileNameWithoutExtension(wavFile.FullName)
                        FileExtensionTextBox.Text = wavFile.Extension
                        ' During automatic fill, use directory name as category.
                        CategoryTextBox.Text = di.Name
                        DataTypeTextBox.Text = "Audio"
                        Application.DoEvents()
                        Me.Validate()
                        Me.SoundsBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.SoundDBDataSet)
                        Application.DoEvents()
                    End If
                    ' Save binary data to database.
                    InsertBinaryData()
                Next
                Me.Enabled = True
            End If
        End With
    End Sub

    Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click
        Try
            Dim sqlString As String = "SELECT BinaryData FROM Sounds WHERE RecordID =" & RecordIDTextBox.Text.Trim
            Using connection As New SqlConnection(My.Settings.MusicDBConnectionString)
                Using command As New SqlCommand(sqlString, connection)
                    Dim bytes() As Byte
                    connection.Open()
                    If Not IsDBNull(command.ExecuteScalar) Then
                        bytes = CType(command.ExecuteScalar(), Byte())
                        Dim stream As MemoryStream = Nothing
                        Try
                            stream = New MemoryStream(bytes, True)
                            stream.Write(bytes, 0, bytes.Length)
                            stream.Flush()
                            My.Computer.Audio.Play(bytes, AudioPlayMode.Background)
                        Catch ex As Exception
                            MessageBox.Show("Unable to play sound: " & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            If stream IsNot Nothing Then
                                stream.Close()
                            End If
                        End Try
                    Else
                        MessageBox.Show("This entry has no sound data.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End Using
            End Using

        Catch ex As SqlException
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region " BindingNavigator Event Handlers "

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Me.SoundsBindingSource.AddNew()
        Me.ButtonFullPath.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove this sound?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.SoundsBindingSource.RemoveCurrent()
            Me.SoundsBindingSource.MoveFirst()
        End If
    End Sub

    Private Sub SoundsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SoundsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SoundDBDataSet)
    End Sub

#End Region

#Region " ToolStripMenuItem Event Handlers "

    Private Sub ToolStripMenuItemExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItemSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemSaveAs.Click
        Try
            With SaveFileDialog1
                If String.IsNullOrEmpty(_LastFolder) Then
                    .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                Else
                    .InitialDirectory = _LastFolder
                End If
                .Filter = "Wave Files (*.wav)|*.wav"
                .FileName = TitleTextBox.Text & FileExtensionTextBox.Text
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim sqlString As String = "SELECT BinaryData FROM Sounds WHERE RecordID =" & RecordIDTextBox.Text.Trim
                    Using connection As New SqlConnection(My.Settings.MusicDBConnectionString)
                        Using command As New SqlCommand(sqlString, connection)
                            Dim bytes() As Byte
                            connection.Open()
                            If Not IsDBNull(command.ExecuteScalar) Then
                                bytes = CType(command.ExecuteScalar(), Byte())
                                Dim stream As FileStream = Nothing
                                Try
                                    stream = New FileStream(.FileName, FileMode.OpenOrCreate)
                                    stream.Write(bytes, 0, bytes.Length)
                                    stream.Flush()
                                Catch ex As IOException
                                    MessageBox.Show("Unable to save file: " & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Finally
                                    If stream IsNot Nothing Then
                                        stream.Close()
                                    End If
                                End Try
                            Else
                                MessageBox.Show("This entry has no sound data.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            End If
                        End Using
                    End Using
                End If
            End With
        Catch ex As SqlException
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItemAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemAbout.Click
        AboutDialog.ShowDialog()
    End Sub

    Private Sub ToolStripButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutDialog.ShowDialog()
    End Sub

#End Region

#Region " Private Methods "

    Private Sub InsertBinaryData()
        Dim fileStream As New FileStream(FullPathTextBox.Text, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(fileStream)
        Dim buffer(CInt(fileStream.Length)) As Byte
        reader.Read(buffer, 0, CInt(fileStream.Length))
        fileStream.Close()
        Using connection As New SqlConnection(My.Settings.MusicDBConnectionString)
            Using command As New SqlCommand("UPDATE Sounds SET BinaryData = @BinaryData WHERE RecordID = @RecordID", connection)
                With command
                    .CommandType = CommandType.Text
                    .Parameters.Add("@BinaryData", SqlDbType.Binary).Value = buffer
                    .Parameters.Add("@RecordID", SqlDbType.Int).Value = CInt(RecordIDTextBox.Text)
                    connection.Open()
                    .ExecuteNonQuery()
                    Dim position As Integer = Me.SoundsBindingSource.CurrencyManager.Position
                    Me.SoundsBindingSource.CurrencyManager.Position = position
                End With
            End Using
        End Using
    End Sub

    Private Shared Function IsCurrentRowNullable(ByVal currentRow As Integer) As Boolean
        Try
            Dim sqlString As String = "SELECT BinaryData FROM Sounds WHERE RecordID =" & currentRow
            Using connection As New SqlConnection(My.Settings.MusicDBConnectionString)
                Using command As New SqlCommand(sqlString, connection)
                    connection.Open()
                    If IsDBNull(command.ExecuteScalar) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

#End Region

End Class
