'
' Copyright � 1997-2009 Herbert N. Swearengen III
'
' Your use of this source-code or compilied software constitues your acceptance of the 
' End-User License Agreement (EULA) provided with this software. The EULA gives you the
' right to use of the accompanying software (Software) for any commercial or noncommercial
' purpose, including distributing derivative works.
'
' In return, we simply require that you agree to the terms of the EULA and include it and all
' copyright notices in any and all derived or distributed works.
'
' This software may include or require the use of software not authored by Herbert N Swearengen III.
' As such, the author is not responsible for any legal consequences involved in the use of such
' software.
'
' THIS SOFTWARE COMES WITHOUT ANY WARRANTY OF ANY KIND. ANY LEGAL DISPUTES INVOLVING IT'S USE ARE
' SOLELY BETWEEN ANY THIRD PARTIES AND THE USER. THE AUTHOR IS NOT INVOLVED IN ANY WAY.


Imports System.IO
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports System
Imports System.Collections
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Reflection
Imports System.Security

''' <summary>
''' Generic About Box for use with my projects. Provides basic system information as well as
''' system up time and the current date and time. The header is a panel which my contain a
''' background image or color. A picture box (48x48 pixels) can display a custom image.
''' 
''' There are two buttons on the form, "Microsoft System Information," which starts msinfo32.exe
''' and "OK," which dismisses the form. Typing Escape on the keyboard will also dismiss the form.
''' 
''' There are two link labels. The first opens a file called "EULA.pdf" Imports the Adobe Reader that
''' is installed on the computer. The "EULA.pdf" file must reside in the application folder. The other
''' link label initiates an email to me. This is normally not visible for non-commercial applications.
''' the application folder.
''' </summary>
''' <remarks>The application will produce an error dialog if msinfo32.exe or EULA.pdf is not found.</remarks>
''' <copyright>Copyright � 2006 Herbert N Swearengen III</copyright>
Public Class AboutDialog

#Region " Private Members "

    Private m_Is64Bit As Boolean
    Private m_DisplayEmailAddress As String = "mailto:hswear3@swbell.net"
    Private m_DisplayWebAddress As String = "http://www.virtualsoftware.com"
    Private m_DisplayPhoneNumber As String = "870-780-6679"

#End Region

#Region " Form Events "

    ''' <summary>
    ''' When user presses the escape key close this form.
    ''' </summary>
    Private Sub AboutForm_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.Close()
        End If

    End Sub

    ''' <summary>
    ''' Form Load Event - assign form level variables, fill out labels on form
    ''' </summary>
    Private Sub AboutForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Try
            ' determine if 32 or 64 bit OS.
            If Directory.Exists(Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%")) Then
                m_Is64Bit = True
            Else
                m_Is64Bit = False
            End If

            '  enable timer
            TimerTickCount.Enabled = True

            '  Get major and minor versions, build and revision and set version on form.
            LabelVersion.Text = My.Application.Info.Title & " Version " & My.Application.Info.Version.Major.ToString & _
                "." & My.Application.Info.Version.Minor.ToString & " Build " & My.Application.Info.Version.Build.ToString & _
                " Revision " & My.Application.Info.Version.Revision.ToString

            '  set title on form
            Me.Text = My.Application.Info.Title

            '  fill in application information
            LabelTitle.Text = My.Application.Info.Title
            LabelCopyright.Text = My.Application.Info.Copyright
            LabelDescription.Text = My.Application.Info.Description

            '  fill in user information
            LabelUser.Text = GetUserCustomerName()
            LabelOrganization.Text = GetUserCustomerOrganization()

            '  fill in company information from assembly trademark.
            LabelCompany.Text = My.Application.Info.Title & " is a product of " & My.Application.Info.CompanyName

            ' Determine support label from Display Company Name.
            LabelSupportAvailable.Text = "Support is available from " & My.Application.Info.CompanyName & ":"

            ' Fill in email link label title.
            LinkLabelEmail.Text = "Email: " & m_DisplayEmailAddress.Replace("mailto:", "")

            ' Fill in website link label title.
            LinkLabelWebsite.Text = "Website: " & m_DisplayWebAddress

            ' Fill in company phone label.
            LabelSupportPhone.Text = "Phone: " & m_DisplayPhoneNumber

            '  fill in system information
            LabelWindowsVersion.Text = My.Computer.Info.OSFullName
            LabelOSDescription.Text = System.Environment.OSVersion.ToString()

            ' Display if 32 or 64 bit OS.
            If m_Is64Bit Then
                LabelOSDescription.Text &= " (64-Bit)"
            Else
                LabelOSDescription.Text &= " (32-Bit)"
            End If

            LabelFramework.Text = ".NET Framework Version " & ReturnHighestFrameworkVersion()

            LabelClrVersion.Text = "Common Language Runtime Version " & GetFrameworkShortVersion()
            If Not String.IsNullOrEmpty(GetFrameworkServicePack()) Or GetFrameworkServicePack() = "0" Then
                LabelClrVersion.Text = LabelClrVersion.Text & " Service Pack " & GetFrameworkServicePack()
            End If

        Catch ex As NullReferenceException
            '  This will trap null references.
            MessageBox.Show(ex.Message.ToString(), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " Link Labels "

    ''' <summary>
    ''' Display EULA if user clicks on link label. Note that this is a PDF file and an
    ''' error will occur if  Adobe Reader is not installed on the user's computer.
    ''' </summary>
    Private Sub linkLabelEULA_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) _
        Handles LinkLabelEULA.LinkClicked

        Dim eula As String = ""

        eula = "Eula.pdf"

        If File.Exists(Application.StartupPath & "\" & eula) Then

            Try
                Dim startInfo As ProcessStartInfo

                '  Now display EULA
                startInfo = New ProcessStartInfo(Application.StartupPath & "\" & eula)
                startInfo.WindowStyle = ProcessWindowStyle.Normal
                Process.Start(startInfo)
            Catch ex As Win32Exception
                '  Cannot find Adobe Reader.
                MessageBox.Show("The EULA file cannot be found, or Adobe Reader is not installed.", _
                    My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            '  Cannot find file.
            MessageBox.Show("The EULA file cannot be found.", _
                    My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    ''' <summary>
    ''' Invoke an email message for support. If no email application is installed or running
    ''' on the user's computer, then an error message will be displayed.
    ''' </summary>
    Private Sub linkLabelEmail_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) _
        Handles LinkLabelEmail.LinkClicked

        Try
            Dim startInfo As ProcessStartInfo

            '  Now send email
            startInfo = New ProcessStartInfo(m_DisplayEmailAddress)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startInfo)

        Catch ex As Win32Exception
            '  Cannot send email.
            MessageBox.Show("Unable to send email.", My.Application.Info.Title, _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub LinkLabelWebsite_LinkClicked(ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelWebsite.LinkClicked

        Try
            Dim startInfo As ProcessStartInfo

            '  Now open website.
            startInfo = New ProcessStartInfo(m_DisplayWebAddress)
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startInfo)

        Catch ex As Win32Exception
            '  Cannot send email.
            MessageBox.Show("Unable to open website.", My.Application.Info.Title, _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


#End Region

#Region " Get NET Framework Information "

    ''' <summary>
    ''' Framework short version, ie: 2.0
    ''' </summary>
    ''' <returns> Returns a string with the version number, if there is an error an
    ''' empty string is returned. </returns>
    Private Shared Function GetFrameworkShortVersion() As String

        Return Environment.Version.ToString().Substring(0, 3)

    End Function

    ''' <summary>
    ''' A special section of the registry has to be querried to find out the service pack
    ''' of the .NET Framework. A different location was used for 1.0 and 1.1, but since this
    ''' application only runs on version 2.0, we won't worry about that.
    ''' </summary>
    ''' <returns> A string containing the version number, for example: "2.0" </returns>
    Private Shared Function GetFrameworkServicePack() As String

        Dim frameworkMajorVersion As String = Environment.Version.Major.ToString()
        Dim frameworkMinorVersion As String = Environment.Version.Minor.ToString()
        Dim frameworkVersion As String = "v" & frameworkMajorVersion & "." & frameworkMinorVersion & "." & Environment.Version.Build.ToString()
        Dim rk As RegistryKey
        Dim temp As String

        Try
            '  try each registry key to determine the version, build, and service pack
            If frameworkMajorVersion = "2" And frameworkMinorVersion = "0" Then

                rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\" & frameworkVersion, False)
                temp = rk.GetValue("SP").ToString()
                If temp <> "0" Then
                    Return temp
                Else
                    Return ""
                End If
            Else
                Return String.Empty
            End If
        Catch ex As Win32Exception
            Return ""
        End Try

    End Function

    ''' <summary>
    ''' Queries the Registry and returns the highest .NET Framework version found or 0 if none is found.
    ''' </summary>
    ''' <returns>A string indicating the major and minor version of the .NET Framework and service pack (if any).</returns>
    ''' <remarks>
    ''' This code is confirmed for versions 2.0, 3.0, 3.5 and 4.0.
    ''' </remarks>
    Private Shared Function ReturnHighestFrameworkVersion() As String

        Const netV20 As String = "Software\Microsoft\NET Framework Setup\NDP\v2.0.50727"
        Const netV30 As String = "Software\Microsoft\NET Framework Setup\NDP\v3.0"
        Const netV35 As String = "Software\Microsoft\NET Framework Setup\NDP\v3.5"
        Const netV40client As String = "Software\Microsoft\NET Framework Setup\NDP\v4\Client"
        Const netV40full As String = "Software\Microsoft\NET Framework Setup\NDP\v4\Full"

        Dim version As Double = 0
        Dim exactVersion As String = ""
        Dim servicePack As String = ""
        Dim full As String = ""
        Dim rk As RegistryKey = Nothing

        ' Surround whole set with Try-Catch to catch generic and security errors.
        Try
            ' Check if version 4.0 full is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV40full)
                    If rk.GetValue("Version").ToString <> "" Then
                        version = 4
                        exactVersion = rk.GetValue("Version").ToString
                        Try
                            servicePack = rk.GetValue("SP").ToString
                        Catch ex As IOException
                            servicePack = ""
                        Catch ex As ArgumentException
                            servicePack = ""
                        Catch ex As NullReferenceException
                            servicePack = ""
                        End Try
                    End If
                    ' Indicate that full framework is installed.
                    full = " (Full) "
                Catch ex As IOException
                    version = 0
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 4.0 client is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV40client)
                    If rk.GetValue("Version").ToString <> "" Then
                        version = 4
                        exactVersion = rk.GetValue("Version").ToString
                        Try
                            servicePack = rk.GetValue("SP").ToString
                        Catch ex As IOException
                            servicePack = ""
                        Catch ex As ArgumentException
                            servicePack = ""
                        Catch ex As NullReferenceException
                            servicePack = ""
                        End Try
                    End If
                    ' Indicate that client is installed.
                    full = " (Client) "
                Catch ex As IOException
                    version = 0
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 3.5 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV35)
                    If rk.GetValue("Version").ToString <> "" Then
                        version = 3.5
                        exactVersion = rk.GetValue("Version").ToString
                        Try
                            servicePack = rk.GetValue("SP").ToString
                        Catch ex As IOException
                            servicePack = ""
                        Catch ex As ArgumentException
                            servicePack = ""
                        Catch ex As NullReferenceException
                            servicePack = ""
                        End Try
                    End If
                    full = ""
                Catch ex As IOException
                    version = 0
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 3.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV30)
                    If rk.GetValue("Version").ToString <> "" Then
                        version = 3
                        exactVersion = rk.GetValue("Version").ToString
                        Try
                            servicePack = rk.GetValue("SP").ToString
                        Catch ex As IOException
                            servicePack = ""
                        Catch ex As ArgumentException
                            servicePack = ""
                        Catch ex As NullReferenceException
                            servicePack = ""
                        End Try
                    End If
                    full = ""
                Catch ex As IOException
                    version = 0
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

            ' Check if version 2.0 is installed. Don't check if version is already found.
            If version = 0 Then
                Try
                    rk = Registry.LocalMachine.OpenSubKey(netV20)
                    If rk.GetValue("Version").ToString <> "" Then
                        version = 2
                        exactVersion = rk.GetValue("Version").ToString
                        Try
                            servicePack = rk.GetValue("SP").ToString
                        Catch ex As IOException
                            servicePack = ""
                        Catch ex As ArgumentException
                            servicePack = ""
                        Catch ex As NullReferenceException
                            servicePack = ""
                        End Try
                    End If
                    full = ""
                Catch ex As IOException
                    version = 0
                Catch ex As ArgumentException
                    version = 0
                Catch ex As NullReferenceException
                    version = 0
                End Try
            End If

        Catch ex As SecurityException
            MessageBox.Show("An error occurred reading the registry. The system returned this information:" _
                & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If rk IsNot Nothing Then
                rk.Close()
            End If
        End Try

        If Not String.IsNullOrEmpty(servicePack) Then
            Return version.ToString("0.0") & " (" & exactVersion & ") Service Pack " & servicePack & full
        Else
            Return version.ToString("0.0") & " (" & exactVersion & ")" & full
        End If

    End Function

#End Region

#Region " Get User Information "

    ''' <summary>
    ''' Query registry for information.
    ''' </summary>
    ''' <returns> Returns customer name as string. </returns>
    Private Function GetUserCustomerOrganization() As String

        Dim rk As RegistryKey

        Try
            Select Case Environment.OSVersion.Platform

                Case PlatformID.Win32Windows

                    rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion", False)
                    Return rk.GetValue("RegisteredOrganization").ToString()

                Case PlatformID.Win32NT

                    If m_Is64Bit Then
                        rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion", False)
                        Return rk.GetValue("RegisteredOrganization").ToString()
                    Else
                        rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion", False)
                        Return rk.GetValue("RegisteredOrganization").ToString()
                    End If

                Case Else
                    Return "Unknown"
            End Select
        Catch ex As Win32Exception
            Return "Unknown"
        End Try

    End Function

    ''' <summary>
    ''' Query registry for information.
    ''' </summary>
    ''' <returns> Returns customer organizationn as string. </returns>
    Private Function GetUserCustomerName() As String

        Try
            Dim rk As RegistryKey

            Select Case System.Environment.OSVersion.Platform

                Case PlatformID.Win32Windows

                    rk = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion", False)
                    Return rk.GetValue("RegisteredOwner").ToString()

                Case PlatformID.Win32NT

                    If m_Is64Bit Then
                        rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion", False)
                        Return rk.GetValue("RegisteredOwner").ToString()
                    Else
                        rk = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion", False)
                        Return rk.GetValue("RegisteredOwner").ToString()
                    End If

                Case Else
                    Return "Unknown"
            End Select

        Catch ex As Win32Exception
            Return "Unknown"
        End Try

    End Function

#End Region

#Region " Get OS Up Time "

    ''' <summary>
    ''' This method gets the system up time by Imports the system clock. Most of this
    ''' code is used to format the output of the system timer (in milliseconds) to
    ''' a more useful format:  DD:HH:MM:SS.
    ''' 
    ''' Note since the system timer rolls over every 47 days, this method will return
    ''' an incorrect value on a system that has been up for more than 47 days.
    ''' 
    ''' This method is called by the timer.
    ''' </summary>
    ''' <returns> A formatted string containing the system up time in the format DD:HH:MM:SS </returns>
    Private Shared Function GetOSUptime() As String

        Try
            Application.DoEvents()

            Dim ticks As Long = CLng(Environment.TickCount / 1000)
            Dim seconds As Long
            Dim minutes As Integer
            Dim hours As Integer
            Dim days As Integer
            Dim displayDays As String = ""
            Dim displayHours As String = ""
            Dim displayMinutes As String = ""
            Dim displaySeconds As String = ""

            seconds = ticks Mod 60
            minutes = CInt(Int((ticks / 60) Mod 60))
            hours = CInt(Int((ticks / 3600) Mod 24))
            days = CInt(Int(ticks / 3600 / 24))

            '  format days
            If days = 0 Then

                displayDays = String.Empty

            ElseIf days.ToString().Length = 1 Then

                displayDays = " " & days.ToString() & ":"

            ElseIf days.ToString().Length = 2 Then

                displayDays = days.ToString() & ":"
            End If

            '  format hours
            If hours = 0 And days = 0 Then

                displayHours = String.Empty

            ElseIf hours.ToString().Length = 1 Then

                displayHours = "0" & hours.ToString() & ":"

            ElseIf hours.ToString().Length = 2 Then

                Dim transTemp9 As String = hours.ToString()
                displayHours = transTemp9 & ":"
            End If

            '  format minutes
            If minutes = 0 Then

                displayMinutes = "00" & ":"

            ElseIf minutes.ToString().Length = 1 Then

                displayMinutes = "0" & minutes.ToString() & ":"

            ElseIf minutes.ToString().Length = 2 Then

                displayMinutes = minutes.ToString() & ":"
            End If

            '  format seconds
            If seconds = 0 Then

                displaySeconds = "00"

            ElseIf seconds.ToString().Length = 1 Then

                displaySeconds = "0" & seconds.ToString()

            ElseIf seconds.ToString().Length = 2 Then

                displaySeconds = seconds.ToString()
            End If

            '  return formatted uptime.
            Return displayDays & displayHours & displayMinutes & displaySeconds

        Catch ex As OverflowException
            Return ""
        End Try

    End Function


#End Region

#Region " Timer Code "

    ''' <summary>
    ''' This timer is used to update the display of system up time and the date and time
    ''' displayed in the StatusStrip at the bottom of the form.
    ''' </summary>
    Private Sub TimerTickCount_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerTickCount.Tick

        '  updates status bar display
        ToolStripLabelDateTime.Text = System.DateTime.Now.ToLongDateString() & " " _
                & System.DateTime.Now.ToLongTimeString()
        ToolStripLabelUpTime.Text = "Up Time: " & GetOSUptime()

    End Sub

#End Region

#Region " Buttons "

    ''' <summary>
    ''' This button will close the form if the form was called with ShowDialog
    ''' </summary>
    Private Sub ButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonOK.Click

        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    ''' <summary>
    ''' This button open Microsoft System Information.
    ''' </summary>
    Private Sub ButtonSysInfo_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles ButtonSysInfo.Click

        Try
            '  Now run msinfo32.
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo("msinfo32.exe")
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            Process.Start(startInfo)

        Catch ex As Win32Exception
            '  Cannot find file.
            MessageBox.Show("Microsoft System Informtion cannot be found.", My.Application.Info.Title, _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

#End Region

End Class