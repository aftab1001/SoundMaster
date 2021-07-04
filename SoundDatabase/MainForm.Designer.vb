<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim RecordIDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim TagsLabel As System.Windows.Forms.Label
        Dim FileExtensionLabel As System.Windows.Forms.Label
        Dim DataTypeLabel As System.Windows.Forms.Label
        Dim FullPathLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ButtonFullPath = New System.Windows.Forms.Button
        Me.TextBoxSearch = New System.Windows.Forms.TextBox
        Me.LabelSearch = New System.Windows.Forms.Label
        Me.ButtonSearch = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonStop = New System.Windows.Forms.Button
        Me.ButtonPlay = New System.Windows.Forms.Button
        Me.ButtonAddFolder = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.ButtonClearSearch = New System.Windows.Forms.Button
        Me.ComboBoxSearchType = New System.Windows.Forms.ComboBox
        Me.LabelSearchType = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemExit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ButtonClearAll = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SoundsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.SoundsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoundDBDataSet = New SoundDatabase.SoundDBDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SoundsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonAbout = New System.Windows.Forms.ToolStripButton
        Me.RecordIDTextBox = New System.Windows.Forms.TextBox
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.CategoryTextBox = New System.Windows.Forms.TextBox
        Me.TagsTextBox = New System.Windows.Forms.TextBox
        Me.FileExtensionTextBox = New System.Windows.Forms.TextBox
        Me.DataTypeTextBox = New System.Windows.Forms.TextBox
        Me.FullPathTextBox = New System.Windows.Forms.TextBox
        Me.SoundsTableAdapter = New SoundDatabase.SoundDBDataSetTableAdapters.SoundsTableAdapter
        Me.TableAdapterManager = New SoundDatabase.SoundDBDataSetTableAdapters.TableAdapterManager
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        RecordIDLabel = New System.Windows.Forms.Label
        TitleLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        CategoryLabel = New System.Windows.Forms.Label
        TagsLabel = New System.Windows.Forms.Label
        FileExtensionLabel = New System.Windows.Forms.Label
        DataTypeLabel = New System.Windows.Forms.Label
        FullPathLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SoundsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SoundsBindingNavigator.SuspendLayout()
        CType(Me.SoundsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoundDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecordIDLabel
        '
        RecordIDLabel.AutoSize = True
        RecordIDLabel.Location = New System.Drawing.Point(37, 98)
        RecordIDLabel.Name = "RecordIDLabel"
        RecordIDLabel.Size = New System.Drawing.Size(61, 15)
        RecordIDLabel.TabIndex = 101
        RecordIDLabel.Text = "Record ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(65, 127)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(33, 15)
        TitleLabel.TabIndex = 102
        TitleLabel.Text = "Title:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(28, 156)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(70, 15)
        DescriptionLabel.TabIndex = 103
        DescriptionLabel.Text = "Description:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(40, 185)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(58, 15)
        CategoryLabel.TabIndex = 104
        CategoryLabel.Text = "Category:"
        '
        'TagsLabel
        '
        TagsLabel.AutoSize = True
        TagsLabel.Location = New System.Drawing.Point(349, 185)
        TagsLabel.Name = "TagsLabel"
        TagsLabel.Size = New System.Drawing.Size(35, 15)
        TagsLabel.TabIndex = 105
        TagsLabel.Text = "Tags:"
        '
        'FileExtensionLabel
        '
        FileExtensionLabel.AutoSize = True
        FileExtensionLabel.Location = New System.Drawing.Point(17, 214)
        FileExtensionLabel.Name = "FileExtensionLabel"
        FileExtensionLabel.Size = New System.Drawing.Size(81, 15)
        FileExtensionLabel.TabIndex = 106
        FileExtensionLabel.Text = "File Extension:"
        '
        'DataTypeLabel
        '
        DataTypeLabel.AutoSize = True
        DataTypeLabel.Location = New System.Drawing.Point(172, 214)
        DataTypeLabel.Name = "DataTypeLabel"
        DataTypeLabel.Size = New System.Drawing.Size(63, 15)
        DataTypeLabel.TabIndex = 107
        DataTypeLabel.Text = "Data Type:"
        '
        'FullPathLabel
        '
        FullPathLabel.AutoSize = True
        FullPathLabel.Location = New System.Drawing.Point(42, 243)
        FullPathLabel.Name = "FullPathLabel"
        FullPathLabel.Size = New System.Drawing.Size(56, 15)
        FullPathLabel.TabIndex = 108
        FullPathLabel.Text = "Full Path:"
        '
        'ButtonFullPath
        '
        Me.ButtonFullPath.Location = New System.Drawing.Point(713, 240)
        Me.ButtonFullPath.Name = "ButtonFullPath"
        Me.ButtonFullPath.Size = New System.Drawing.Size(34, 23)
        Me.ButtonFullPath.TabIndex = 66
        Me.ButtonFullPath.Text = ". . ."
        Me.ButtonFullPath.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(297, 67)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(280, 23)
        Me.TextBoxSearch.TabIndex = 54
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearch.Location = New System.Drawing.Point(246, 70)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(45, 15)
        Me.LabelSearch.TabIndex = 53
        Me.LabelSearch.Text = "Search:"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(583, 66)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 51
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonStop
        '
        Me.ButtonStop.Image = Global.SoundDatabase.My.Resources.Resources.StopPlay
        Me.ButtonStop.Location = New System.Drawing.Point(185, 279)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStop.TabIndex = 88
        Me.ToolTip1.SetToolTip(Me.ButtonStop, "Stop")
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Image = Global.SoundDatabase.My.Resources.Resources.Play
        Me.ButtonPlay.Location = New System.Drawing.Point(104, 279)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPlay.TabIndex = 110
        Me.ToolTip1.SetToolTip(Me.ButtonPlay, "Play")
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'ButtonAddFolder
        '
        Me.ButtonAddFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddFolder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddFolder.Location = New System.Drawing.Point(672, 279)
        Me.ButtonAddFolder.Name = "ButtonAddFolder"
        Me.ButtonAddFolder.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddFolder.TabIndex = 89
        Me.ButtonAddFolder.Text = "Add Folder"
        Me.ToolTip1.SetToolTip(Me.ButtonAddFolder, "Add all sounds in folder")
        Me.ButtonAddFolder.UseVisualStyleBackColor = True
        '
        'ButtonClearSearch
        '
        Me.ButtonClearSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClearSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearSearch.Location = New System.Drawing.Point(664, 67)
        Me.ButtonClearSearch.Name = "ButtonClearSearch"
        Me.ButtonClearSearch.Size = New System.Drawing.Size(83, 23)
        Me.ButtonClearSearch.TabIndex = 90
        Me.ButtonClearSearch.Text = "Clear Search"
        Me.ButtonClearSearch.UseVisualStyleBackColor = True
        '
        'ComboBoxSearchType
        '
        Me.ComboBoxSearchType.FormattingEnabled = True
        Me.ComboBoxSearchType.Items.AddRange(New Object() {"Title", "Description", "Category", "Tags", "Comment"})
        Me.ComboBoxSearchType.Location = New System.Drawing.Point(104, 66)
        Me.ComboBoxSearchType.Name = "ComboBoxSearchType"
        Me.ComboBoxSearchType.Size = New System.Drawing.Size(136, 23)
        Me.ComboBoxSearchType.TabIndex = 91
        Me.ComboBoxSearchType.Text = "Title"
        '
        'LabelSearchType
        '
        Me.LabelSearchType.AutoSize = True
        Me.LabelSearchType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSearchType.Location = New System.Drawing.Point(24, 69)
        Me.LabelSearchType.Name = "LabelSearchType"
        Me.LabelSearchType.Size = New System.Drawing.Size(74, 15)
        Me.LabelSearchType.TabIndex = 92
        Me.LabelSearchType.Text = "Search Type:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFile, Me.ToolStripMenuItemHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 24)
        Me.MenuStrip1.TabIndex = 93
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemFile
        '
        Me.ToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSaveAs, Me.ToolStripMenuItemExit})
        Me.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile"
        Me.ToolStripMenuItemFile.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItemFile.Text = "&File"
        '
        'ToolStripMenuItemSaveAs
        '
        Me.ToolStripMenuItemSaveAs.Name = "ToolStripMenuItemSaveAs"
        Me.ToolStripMenuItemSaveAs.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItemSaveAs.Text = "Save As"
        '
        'ToolStripMenuItemExit
        '
        Me.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit"
        Me.ToolStripMenuItemExit.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItemExit.Text = "E&xit"
        '
        'ToolStripMenuItemHelp
        '
        Me.ToolStripMenuItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemAbout})
        Me.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp"
        Me.ToolStripMenuItemHelp.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItemHelp.Text = "&Help"
        '
        'ToolStripMenuItemAbout
        '
        Me.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout"
        Me.ToolStripMenuItemAbout.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItemAbout.Text = "&About"
        '
        'ButtonClearAll
        '
        Me.ButtonClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClearAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearAll.Location = New System.Drawing.Point(591, 279)
        Me.ButtonClearAll.Name = "ButtonClearAll"
        Me.ButtonClearAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearAll.TabIndex = 94
        Me.ButtonClearAll.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.ButtonClearAll, "Clear all database entries")
        Me.ButtonClearAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Media Player:"
        '
        'SoundsBindingNavigator
        '
        Me.SoundsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SoundsBindingNavigator.BindingSource = Me.SoundsBindingSource
        Me.SoundsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SoundsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SoundsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SoundsBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButtonAbout})
        Me.SoundsBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.SoundsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SoundsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SoundsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SoundsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SoundsBindingNavigator.Name = "SoundsBindingNavigator"
        Me.SoundsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SoundsBindingNavigator.Size = New System.Drawing.Size(771, 25)
        Me.SoundsBindingNavigator.TabIndex = 101
        Me.SoundsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'SoundsBindingSource
        '
        Me.SoundsBindingSource.DataMember = "Sounds"
        Me.SoundsBindingSource.DataSource = Me.SoundDBDataSet
        '
        'SoundDBDataSet
        '
        Me.SoundDBDataSet.DataSetName = "SoundDBDataSet"
        Me.SoundDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SoundsBindingNavigatorSaveItem
        '
        Me.SoundsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SoundsBindingNavigatorSaveItem.Image = CType(resources.GetObject("SoundsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SoundsBindingNavigatorSaveItem.Name = "SoundsBindingNavigatorSaveItem"
        Me.SoundsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SoundsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonAbout
        '
        Me.ToolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAbout.Image = Global.SoundDatabase.My.Resources.Resources.About
        Me.ToolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAbout.Name = "ToolStripButtonAbout"
        Me.ToolStripButtonAbout.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButtonAbout.Text = "ToolStripButton1"
        '
        'RecordIDTextBox
        '
        Me.RecordIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "RecordID", True))
        Me.RecordIDTextBox.Location = New System.Drawing.Point(104, 95)
        Me.RecordIDTextBox.Name = "RecordIDTextBox"
        Me.RecordIDTextBox.ReadOnly = True
        Me.RecordIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.RecordIDTextBox.TabIndex = 102
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(104, 124)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(643, 23)
        Me.TitleTextBox.TabIndex = 103
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(104, 153)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(643, 23)
        Me.DescriptionTextBox.TabIndex = 104
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(104, 182)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(237, 23)
        Me.CategoryTextBox.TabIndex = 105
        '
        'TagsTextBox
        '
        Me.TagsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "Tags", True))
        Me.TagsTextBox.Location = New System.Drawing.Point(390, 182)
        Me.TagsTextBox.Name = "TagsTextBox"
        Me.TagsTextBox.Size = New System.Drawing.Size(357, 23)
        Me.TagsTextBox.TabIndex = 106
        '
        'FileExtensionTextBox
        '
        Me.FileExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "FileExtension", True))
        Me.FileExtensionTextBox.Location = New System.Drawing.Point(104, 211)
        Me.FileExtensionTextBox.Name = "FileExtensionTextBox"
        Me.FileExtensionTextBox.Size = New System.Drawing.Size(55, 23)
        Me.FileExtensionTextBox.TabIndex = 107
        '
        'DataTypeTextBox
        '
        Me.DataTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "DataType", True))
        Me.DataTypeTextBox.Location = New System.Drawing.Point(241, 211)
        Me.DataTypeTextBox.Name = "DataTypeTextBox"
        Me.DataTypeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.DataTypeTextBox.TabIndex = 108
        '
        'FullPathTextBox
        '
        Me.FullPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SoundsBindingSource, "FullPath", True))
        Me.FullPathTextBox.Location = New System.Drawing.Point(104, 240)
        Me.FullPathTextBox.Name = "FullPathTextBox"
        Me.FullPathTextBox.Size = New System.Drawing.Size(603, 23)
        Me.FullPathTextBox.TabIndex = 109
        '
        'SoundsTableAdapter
        '
        Me.SoundsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SoundsTableAdapter = Me.SoundsTableAdapter
        Me.TableAdapterManager.UpdateOrder = SoundDatabase.SoundDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(771, 331)
        Me.Controls.Add(Me.ButtonPlay)
        Me.Controls.Add(FullPathLabel)
        Me.Controls.Add(Me.FullPathTextBox)
        Me.Controls.Add(DataTypeLabel)
        Me.Controls.Add(Me.DataTypeTextBox)
        Me.Controls.Add(FileExtensionLabel)
        Me.Controls.Add(Me.FileExtensionTextBox)
        Me.Controls.Add(TagsLabel)
        Me.Controls.Add(Me.TagsTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(RecordIDLabel)
        Me.Controls.Add(Me.RecordIDTextBox)
        Me.Controls.Add(Me.SoundsBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonClearAll)
        Me.Controls.Add(Me.LabelSearchType)
        Me.Controls.Add(Me.ComboBoxSearchType)
        Me.Controls.Add(Me.ButtonClearSearch)
        Me.Controls.Add(Me.ButtonAddFolder)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonFullPath)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sound Database"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SoundsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SoundsBindingNavigator.ResumeLayout(False)
        Me.SoundsBindingNavigator.PerformLayout()
        CType(Me.SoundsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoundDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ButtonFullPath As System.Windows.Forms.Button
    Private WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Private WithEvents LabelSearch As System.Windows.Forms.Label
    Private WithEvents ButtonSearch As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents ButtonAddFolder As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents ButtonClearSearch As System.Windows.Forms.Button
    Friend WithEvents ComboBoxSearchType As System.Windows.Forms.ComboBox
    Private WithEvents LabelSearchType As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemAbout As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ButtonClearAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SoundDBDataSet As SoundDatabase.SoundDBDataSet
    Friend WithEvents SoundsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoundsTableAdapter As SoundDatabase.SoundDBDataSetTableAdapters.SoundsTableAdapter
    Friend WithEvents TableAdapterManager As SoundDatabase.SoundDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SoundsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SoundsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RecordIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TagsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileExtensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItemSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
