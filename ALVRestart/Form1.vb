Public Class Form1
    Dim browsercommand As String
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.PictureBox1.Capture = False   'change this to the control you will use to move the window
            ' Create and send a WM_NCLBUTTONDOWN message.
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = _
             Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
              New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.LightMode = True Then
            Me.BackColor = Color.FromArgb(234, 234, 234)
            LightDarkToggle.Image = My.Resources.DarkLightToggle_OFF
            PictureBox1.Image = My.Resources.HeaderLogo_Light
            Button1.FlatAppearance.BorderColor = Color.Black
            Button1.ForeColor = Color.Black
            Button2.FlatAppearance.BorderColor = Color.Black
            Button2.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            LinkLabel1.LinkColor = Color.Black
        Else
            Me.BackColor = Color.FromArgb(13, 14, 21)
            LightDarkToggle.Image = My.Resources.DarkLightToggle_ON
            PictureBox1.Image = My.Resources.HeaderLogo
            Button1.FlatAppearance.BorderColor = Color.FromArgb(234, 234, 234)
            Button1.ForeColor = Color.FromArgb(234, 234, 234)
            Button2.FlatAppearance.BorderColor = Color.FromArgb(234, 234, 234)
            Button2.ForeColor = Color.FromArgb(234, 234, 234)
            Label1.ForeColor = Color.FromArgb(234, 234, 234)
            LinkLabel1.LinkColor = Color.FromArgb(234, 234, 234)
        End If
    End Sub

    Private Sub LightDarkToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LightDarkToggle.Click
        If My.Settings.LightMode = False Then
            My.Settings.LightMode = True
            My.Settings.Save()
            Me.BackColor = Color.FromArgb(234, 234, 234)
            LightDarkToggle.Image = My.Resources.DarkLightToggle_OFF
            PictureBox1.Image = My.Resources.HeaderLogo_Light
            Button1.FlatAppearance.BorderColor = Color.Black
            Button1.ForeColor = Color.Black
            Button2.FlatAppearance.BorderColor = Color.Black
            Button2.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            LinkLabel1.LinkColor = Color.Black
        Else
            My.Settings.LightMode = False
            My.Settings.Save()
            Me.BackColor = Color.FromArgb(13, 14, 21)
            LightDarkToggle.Image = My.Resources.DarkLightToggle_ON
            PictureBox1.Image = My.Resources.HeaderLogo
            Button1.FlatAppearance.BorderColor = Color.FromArgb(234, 234, 234)
            Button1.ForeColor = Color.FromArgb(234, 234, 234)
            Button2.FlatAppearance.BorderColor = Color.FromArgb(234, 234, 234)
            Button2.ForeColor = Color.FromArgb(234, 234, 234)
            Label1.ForeColor = Color.FromArgb(234, 234, 234)
            LinkLabel1.LinkColor = Color.FromArgb(234, 234, 234)
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Process.Start("https://soafen.love/software")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.soafen
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = Nothing
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Application.Exit()
        End
    End Sub


    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        My.Settings.Browser = ComboBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        browsercommand = "/C taskkill /F /im " & My.Settings.Browser
        Try
            Process.Start("CMD", browsercommand)
            Process.Start("CMD", "/C taskkill /F /im vrwebhelper.exe")
            Process.Start("CMD", "/C taskkill /F /im vrserver.exe")
            Process.Start("CMD", "/C taskkill /F /im vrmonitor.exe")
            Process.Start("CMD", "/C taskkill /F /im ALVR Launcher.exe")
            Timer1.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Process.Start("C:\Program Files\ALVR\ALVR Launcher.exe")
        Catch ex As Exception

        End Try
        Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        browsercommand = "/C taskkill /F /im " & My.Settings.Browser
        Try
            Process.Start("CMD", browsercommand)
            Process.Start("CMD", "/C taskkill /F /im vrwebhelper.exe")
            Process.Start("CMD", "/C taskkill /F /im vrserver.exe")
            Process.Start("CMD", "/C taskkill /F /im vrmonitor.exe")
            Process.Start("CMD", "/C taskkill /F /im ALVR Launcher.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ComboBox1.Text = My.Settings.Browser
    End Sub
End Class
