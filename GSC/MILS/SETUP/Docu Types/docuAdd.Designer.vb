﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class docuAdd
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbxDocName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxDocRem = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdPrim = New System.Windows.Forms.RadioButton()
        Me.rdSec = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdRecv = New System.Windows.Forms.RadioButton()
        Me.rdRels = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 218)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Button1)
        Me.PanelControl1.Controls.Add(Me.tbxDocName)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.tbxDocRem)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.btnAdd)
        Me.PanelControl1.Controls.Add(Me.lblErr)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Location = New System.Drawing.Point(6, 21)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(365, 185)
        Me.PanelControl1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Doc. Code:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbxDocName
        '
        Me.tbxDocName.Location = New System.Drawing.Point(106, 10)
        Me.tbxDocName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxDocName.Name = "tbxDocName"
        Me.tbxDocName.Size = New System.Drawing.Size(250, 21)
        Me.tbxDocName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "*"
        '
        'tbxDocRem
        '
        Me.tbxDocRem.Location = New System.Drawing.Point(106, 40)
        Me.tbxDocRem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxDocRem.Name = "tbxDocRem"
        Me.tbxDocRem.Size = New System.Drawing.Size(250, 21)
        Me.tbxDocRem.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdPrim)
        Me.GroupBox3.Controls.Add(Me.rdSec)
        Me.GroupBox3.Location = New System.Drawing.Point(236, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 71)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type"
        '
        'rdPrim
        '
        Me.rdPrim.AutoSize = True
        Me.rdPrim.Checked = True
        Me.rdPrim.Location = New System.Drawing.Point(6, 18)
        Me.rdPrim.Name = "rdPrim"
        Me.rdPrim.Size = New System.Drawing.Size(61, 17)
        Me.rdPrim.TabIndex = 0
        Me.rdPrim.TabStop = True
        Me.rdPrim.Text = "Primary"
        Me.rdPrim.UseVisualStyleBackColor = True
        '
        'rdSec
        '
        Me.rdSec.AutoSize = True
        Me.rdSec.Location = New System.Drawing.Point(6, 45)
        Me.rdSec.Name = "rdSec"
        Me.rdSec.Size = New System.Drawing.Size(76, 17)
        Me.rdSec.TabIndex = 1
        Me.rdSec.Text = "Secondary"
        Me.rdSec.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Description:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdRecv)
        Me.GroupBox2.Controls.Add(Me.rdRels)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 71)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Category"
        '
        'rdRecv
        '
        Me.rdRecv.AutoSize = True
        Me.rdRecv.Checked = True
        Me.rdRecv.Location = New System.Drawing.Point(7, 18)
        Me.rdRecv.Name = "rdRecv"
        Me.rdRecv.Size = New System.Drawing.Size(71, 17)
        Me.rdRecv.TabIndex = 0
        Me.rdRecv.TabStop = True
        Me.rdRecv.Text = "Receiving"
        Me.rdRecv.UseVisualStyleBackColor = True
        '
        'rdRels
        '
        Me.rdRels.AutoSize = True
        Me.rdRels.Location = New System.Drawing.Point(7, 45)
        Me.rdRels.Name = "rdRels"
        Me.rdRels.Size = New System.Drawing.Size(71, 17)
        Me.rdRels.TabIndex = 1
        Me.rdRels.Text = "Releasing"
        Me.rdRels.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(281, 146)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 25)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblErr
        '
        Me.lblErr.AutoSize = True
        Me.lblErr.ForeColor = System.Drawing.Color.Red
        Me.lblErr.Location = New System.Drawing.Point(11, 148)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(13, 13)
        Me.lblErr.TabIndex = 19
        Me.lblErr.Text = "*"
        Me.lblErr.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(5, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "*"
        '
        'docuAdd
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 218)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconOptions.ShowIcon = False
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "docuAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblErr As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxDocRem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxDocName As TextBox
    Friend WithEvents rdSec As RadioButton
    Friend WithEvents rdPrim As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdRecv As RadioButton
    Friend WithEvents rdRels As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Private WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
