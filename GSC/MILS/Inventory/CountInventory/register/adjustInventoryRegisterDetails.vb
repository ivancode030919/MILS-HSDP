Public Class adjustInventoryRegisterDetails
    Private q As New qry
    Public id As String = ""
    Public encoder As String = ""
    Private n As New qryv3
    Private Sub adjustInventoryRegisterDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newLVFormat()
        loadencoder()
        loadlv()

        If newHome.roleId = 20020 Then
            GroupBox2.Enabled = True
            GroupBox2.Visible = True

        Else
            GroupBox2.Enabled = False
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub newLVFormat()
        With lvInvAdjDetails
            .Columns.Add("dummy", 0)
            .Columns.Add("PRODUCT NUMBER", 130, HorizontalAlignment.Center)
            .Columns.Add("DESCRIPTION", 400, HorizontalAlignment.Left)
            .Columns.Add("BATCH", 100, HorizontalAlignment.Center)
            .Columns.Add("LOCATION", 100, HorizontalAlignment.Center)
            .Columns.Add("EXPIRATION DATE", 150, HorizontalAlignment.Center)
            .Columns.Add("ON HAND", 90, HorizontalAlignment.Center)
            .Columns.Add("COUNT", 90, HorizontalAlignment.Center)
            .Columns.Add("DIFFERENCE", 150, HorizontalAlignment.Center)
        End With
    End Sub

    Sub loadlv()
        q.fetchDatasInventoryAdjustDetails(lvInvAdjDetails, id)
    End Sub

    Sub loadencoder()
        q.loadforinventorycountencoder(encoder)
    End Sub


    Private Sub adjustInventoryRegisterDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Home_Page.Enabled = True
            adjustInventoryRegister.Enabled = True
            Me.Dispose()
            adjustInventoryRegister.Focus()
            adjustInventoryRegister.Select()
        End If
    End Sub

    Private Sub adjustInventoryRegisterDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home_Page.Enabled = True
        adjustInventoryRegister.Enabled = True
        adjustInventoryRegister.Focus()
        adjustInventoryRegister.Select()
    End Sub



    Private Sub lvInvAdjDetails_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvInvAdjDetails.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = lvInvAdjDetails.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        loadencoder()
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            tbxEntryNum.Enabled = False
            GroupBox1.Enabled = False
            rb1.Checked = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            tbxEntryNum.Enabled = False
            GroupBox1.Enabled = True
            rb2.Checked = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n.updateCOUNTheader(id, dtpDate.Value, tbxRemarks.Text, TextBox2.Text)
    End Sub

End Class