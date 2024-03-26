Imports System.Runtime.Remoting.Contexts
Imports System.Security
Imports System.Net
'developers::::::::::::::::::::
'nag start -JC
'preceedor - junie cool
'april 2023 - ivan bajenting

Public Class login_page
    Private q As New qry
    Private IPADD As String
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxUser.Select()
        tbxUser.Focus()
        Panel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Timer1.Enabled = True
        IPADD = GetIPv4Address()

        checkstat()
    End Sub

    'for ip to be record and check if its open or closed
    Private Sub checkstat()
        q.addandcheckIP(IPADD)
    End Sub


    Function GetIPv4Address() As String
        Dim hostName As String = Dns.GetHostName()
        Dim ipAddresses As IPAddress() = Dns.GetHostEntry(hostName).AddressList

        Dim ipv4Address As String = ""
        For Each ipAddress As IPAddress In ipAddresses
            If ipAddress.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                ipv4Address = ipAddress.ToString()
                Exit For ' Only retrieve the first IPv4 address
            End If
        Next

        Return ipv4Address
    End Function

    Sub validateUser()
        If String.IsNullOrWhiteSpace(tbxUser.Text) And String.IsNullOrWhiteSpace(tbxPass.Text) Then

            MessageBox.Show("Username and Password is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            'q.logInUser(tbxUsernam.Text, tbxPassword.Text)
            q.logInUser(tbxUser.Text, tbxPass.Text)
        End If
    End Sub



    Private Sub btnCanel_Click(sender As Object, e As EventArgs) Handles btnCanel.Click
        Dim btnClose As Boolean = True
        If (MessageBox.Show("Are you sure you want to close this application?", "Info", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No) Then
            btnClose = True
        Else
            btnClose = False
            Application.Exit()
        End If
    End Sub

    Private Sub login_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim btnClose As Boolean = True
        If e.KeyCode = Keys.Escape Then
            If (MessageBox.Show("Are you sure you want to close this application?", "Info", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No) Then
                btnClose = True
            Else
                btnClose = False
                Application.Exit()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            validateUser()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        validateUser()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Login_page_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        q.addandcheckIPwhenclose(IPADD)
    End Sub

    Private Sub login_page_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        q.addandcheckIPwhenclose(IPADD)
    End Sub
End Class