Public Class inventoryGoodsDetails
    Private q As New qry
    Public id As String = ""
    Private n As New qryv3
    Private Sub inventoryGoodsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newLVFormat()
        tbxApprvdBy.Visible = True
        Label6.Visible = True
        loadLV()
        lvDetails.Select()

        If newHome.roleId = 20020 Then
            GroupBox2.Enabled = True
            GroupBox2.Visible = True

        Else
            GroupBox2.Enabled = False
            GroupBox2.Visible = False
        End If
    End Sub

    Sub newLVFormat()
        With lvDetails
            .Columns.Add("dummy", 0)
            .Columns.Add("PRODUCT NUMBER", 150, HorizontalAlignment.Center)
            .Columns.Add("DESCRIPTION", 570)
            .Columns.Add("BATCH", 100, HorizontalAlignment.Center)
            .Columns.Add("LOCATIONS", 120, HorizontalAlignment.Center)
            .Columns.Add("QUANTITY", 100, HorizontalAlignment.Center)
            .Columns.Add("EXPIRATION DATE", 150, HorizontalAlignment.Center)
            lvDetails.HeaderStyle = ColumnHeaderStyle.Nonclickable
        End With
    End Sub

    Sub loadLV()
        q.fetchLoadProductAutoBuild(lvDetails, id)
        If lvDetails.Items.Count = 0 Then
            lblErr.Visible = True
            lblErr.Text = "No data found..."
        Else
            lblErr.Visible = False
        End If
    End Sub

    Private Sub inventoryGoodsDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Home_Page.Enabled = True
        inventoryGoods.Enabled = True
        With inventoryGoods
            .lvInventory.SelectedItems.Clear()
        End With
    End Sub

    Private Sub inventoryGoodsDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Home_Page.Enabled = True
            inventoryGoods.Enabled = True
            Me.Dispose()
            With inventoryGoods
                .lvInventory.SelectedItems.Clear()
            End With
        End If
    End Sub

    Private Sub lvDetails_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvDetails.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = Me.lvDetails.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n.updateBuildheader(id, dtpDate.Value, tbxRemarks.Text, cbxOwnership.Text, tbxDocNum.Text)
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            tbxEntryNumber.Enabled = False
            GroupBox3.Enabled = False
            rb1.Checked = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            tbxEntryNumber.Enabled = False
            GroupBox3.Enabled = True
            rb2.Checked = False
            Button1.Enabled = True
        End If
    End Sub
End Class