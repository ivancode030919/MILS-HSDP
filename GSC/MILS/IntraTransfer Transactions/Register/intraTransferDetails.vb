Public Class intraTransferDetails
    Private q As New qry
    Public id As String = ""
    Private n As New qryv3
    Private Sub intraTransferDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvNewFormat()
        'tbxApprovedBy.Visible = False
        'Label4.Visible = False
        loadLV()


        If newHome.roleId = 20020 Then
            GroupBox2.Enabled = True
            GroupBox2.Visible = True

        Else
            GroupBox2.Enabled = False
            GroupBox2.Visible = False
        End If
    End Sub

    Sub lvNewFormat()
        With lvIntraTransferDetails
            .Columns.Add("dummy", 0)
            .Columns.Add("PRODUCT NUMBER", 130, HorizontalAlignment.Center)
            .Columns.Add("DESCRIPTION", 500, HorizontalAlignment.Left)
            .Columns.Add("BATCH CODE", 100, HorizontalAlignment.Center)
            .Columns.Add("SOURCE LOCATION", 120, HorizontalAlignment.Center)
            .Columns.Add("DESTINATION", 110, HorizontalAlignment.Center)
            .Columns.Add("QUANTITY", 90, HorizontalAlignment.Center)
            .Columns.Add("EXPIRATION DATE", 130, HorizontalAlignment.Center)
        End With
    End Sub

    Sub loadLV()
        q.fetchIntraTransferDetails(lvIntraTransferDetails, id)


    End Sub

    Private Sub intraTransferDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home_Page.Enabled = True
        intraTransferRegister.Enabled = True
        intraTransferRegister.lvIntraTransfer.Select()
    End Sub

    Private Sub intraTransferDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Home_Page.Enabled = True
            intraTransferRegister.Enabled = True
            intraTransferRegister.lvIntraTransfer.Select()
            Me.Dispose()
        End If
    End Sub

    Private Sub lvIntraTransferDetails_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvIntraTransferDetails.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = Me.lvIntraTransferDetails.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            tbxEntryNumber.Enabled = False
            GroupBox1.Enabled = False
            rb1.Checked = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            tbxEntryNumber.Enabled = False
            GroupBox1.Enabled = True
            rb2.Checked = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        n.updateTransferheader(id, dtpTransferDate.Value, tbxRemarks.Text, tbxTransferId.Text)
    End Sub
End Class