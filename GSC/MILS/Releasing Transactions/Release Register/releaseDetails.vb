Public Class releaseDetails
    Public transId As String
    Private q As New qry
    Private n As New qryv3
    Public doctype As String = ""
    Public refdoctype As String = ""
    Public receiver As String = ""
    Public loc As String = ""
    Public batch As String = ""
    Public area As String = ""
    Private Sub releaseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'newLVFormat()
        loadCBX()
        loadDetails()
        cbxReceiver.Select()
        n.batchIdsss()
        n.locidsss()

        If newHome.roleId = 20020 Then
            GroupBox1.Enabled = True
            loadclass()
            loadTbxDocType()
            loadtbxRefDocType()
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            gb3.Enabled = False
            GroupBox4.Enabled = False
            'GroupBox4.Location = New Point(800, 8)
        End If
    End Sub

    Private Sub loadclass()
        n.doctype(tbxDocType.Text)
        n.doctype2(tbxRefDocType.Text)


    End Sub

    Sub loadTbxDocType()
        With tbxDocType
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim col As New AutoCompleteStringCollection()
            'q.suggestDocType(col)
            q.suggestDocTypeRels(col)
            .AutoCompleteCustomSource = col
        End With
    End Sub

    Sub loadtbxRefDocType()
        With tbxRefDocType
            .Refresh()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            Dim col As New AutoCompleteStringCollection()
            'q.suggestRefDocType(col)
            q.suggestRefDocTypeRels(col)
            .AutoCompleteCustomSource = col
        End With
    End Sub
    Sub loadCBX()
        q.loadSender(cbxReceiver) 'load sender combox
    End Sub

    Sub loadDetails()
        q.loadLVRelsDetails(transId)
    End Sub

    Private Sub releaseDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        releaseRegister.Enabled = True

    End Sub

    Sub closethisform()
        releaseRegister.Enabled = True

        Me.Dispose()
    End Sub

    Private Sub releaseDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub lvRecvDetails_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs)
        'e.Cancel = True
        'e.NewWidth = Me.lvRecvDetails.Columns(e.ColumnIndex).Width
    End Sub

    Private Sub Rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked = True Then
            GroupBox2.Enabled = False
            gb3.Enabled = False
            GroupBox4.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            GroupBox2.Enabled = True
            gb3.Enabled = True
            GroupBox4.Enabled = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'n.relupdate(tbxEntry.Text, doctype, tbxDocNum.Text, dtpRefDate.Value, tbxRemarks.Text, tbxRefDocType.Text, tbxRefDocNum.Text, cbxOwnership.Text)
        n.relupdate(tbxEntry.Text, tbxDocNum.Text, dtpRefDate.Value, tbxRemarks.Text, tbxRefDocNum.Text, cbxOwnership.Text, doctype, receiver, refdoctype)
        rb2.Checked = True
    End Sub

    Private Sub Dg1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellDoubleClick
        Dim row As Integer = dg1.CurrentCell.RowIndex
        If e.ColumnIndex = 1 Then

            With selectProducts
                .ed = True
                .loadLV()
                .Show()
                .targetRow = row
            End With
        End If
    End Sub

    Private Sub Dg1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dg1.CellValidating
        Dim row As DataGridViewRow = dg1.Rows(e.RowIndex)
        Dim countedQty As Double = 0
        Dim onhandQty As Double = 0
        Dim differenceQty As Double = 0
        Try
            If e.ColumnIndex = 5 Then
                With dg1

                    countedQty = row.Cells(10).Value.ToString
                    onhandQty = e.FormattedValue
                    differenceQty = onhandQty - countedQty

                    If differenceQty > 0 Then
                        differenceQty = -differenceQty
                    ElseIf differenceQty < 0 Then
                        differenceQty = Math.Abs(differenceQty)
                    End If

                    row.Cells(11).Value = differenceQty.ToString

                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Please Input Counted Quantity!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub

    Private Sub CbxReceiver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxReceiver.SelectedIndexChanged
        n.relreceiver(cbxReceiver.Text)
    End Sub

    Private Sub TbxDocType_TextChanged(sender As Object, e As EventArgs) Handles tbxDocType.TextChanged
        loadclass()
    End Sub

    Private Sub TbxRefDocType_TextChanged(sender As Object, e As EventArgs) Handles tbxRefDocType.TextChanged
        loadclass()
    End Sub

    Private Sub Dg1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dg1.RowValidating
        Dim row As DataGridViewRow = dg1.Rows(e.RowIndex)
        Dim isValidQty As Boolean = True
        Dim repeatingId As Boolean = False
        Dim isEmpty As Boolean

        Try
            With dg1
                If .IsCurrentRowDirty Then
                    Dim idDGV As String = ""
                    idDGV = row.Cells(7).Value.ToString
                    Dim qtyDGV As String = ""
                    qtyDGV = row.Cells(5).Value.ToString
                    Dim id As String = ""
                    id = row.Cells(0).Value.ToString


                    For Each cell As DataGridViewCell In row.Cells 'is null
                        If String.IsNullOrWhiteSpace(cell.Value.ToString) Then
                            e.Cancel = True
                            isEmpty = True
                        End If
                    Next

                    For i As Integer = 0 To Me.dg1.RowCount - 1
                        For j As Integer = 0 To Me.dg1.RowCount - 1
                            If i <> j Then
                                If dg1.Rows(i).Cells(0).Value = dg1.Rows(j).Cells(0).Value Then
                                    'dgvRels.Rows(i).DefaultCellStyle.BackColor = Color.Red
                                    e.Cancel = True
                                    'l5.Visible = True
                                    'l5.Text = "Duplicate data are not valid."
                                    MsgBox("Duplicate data are not valid.")
                                    repeatingId = True
                                Else
                                    'dgvRels.Rows(i).DefaultCellStyle.BackColor = Color.White
                                End If
                            End If
                        Next
                    Next


                    Try
                        isValidQty = q.validationQuantityProdedit(idDGV, qtyDGV, id) ' check the quantity
                    Catch ex As Exception
                        MessageBox.Show("Fields with * are required.", "Error",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                    If isEmpty = True Then
                        e.Cancel = True
                        MessageBox.Show("Fields with * are required.", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf isValidQty = False Then
                        e.Cancel = True
                        MessageBox.Show("You do not have enough of these items.", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf repeatingId = False Then
                        'l5.Visible = True
                    End If


                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class