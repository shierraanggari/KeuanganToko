<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteBarangMasuk
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabID = New System.Windows.Forms.Label()
        Me.BTNYa = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.LabelNamaBarang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hapus Data"
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(194, 112)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(24, 20)
        Me.LabID.TabIndex = 1
        Me.LabID.Text = "ID"
        '
        'BTNYa
        '
        Me.BTNYa.Location = New System.Drawing.Point(98, 188)
        Me.BTNYa.Name = "BTNYa"
        Me.BTNYa.Size = New System.Drawing.Size(94, 29)
        Me.BTNYa.TabIndex = 2
        Me.BTNYa.Text = "Ya"
        Me.BTNYa.UseVisualStyleBackColor = True
        '
        'BTNCancel
        '
        Me.BTNCancel.Location = New System.Drawing.Point(224, 188)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(94, 29)
        Me.BTNCancel.TabIndex = 3
        Me.BTNCancel.Text = "Batal"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'LabelNamaBarang
        '
        Me.LabelNamaBarang.AutoSize = True
        Me.LabelNamaBarang.Location = New System.Drawing.Point(160, 141)
        Me.LabelNamaBarang.Name = "LabelNamaBarang"
        Me.LabelNamaBarang.Size = New System.Drawing.Size(100, 20)
        Me.LabelNamaBarang.TabIndex = 4
        Me.LabelNamaBarang.Text = "Nama Barang"
        '
        'DeleteBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 274)
        Me.Controls.Add(Me.LabelNamaBarang)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNYa)
        Me.Controls.Add(Me.LabID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeleteBarangMasuk"
        Me.Text = "DeleteBarangMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabID As Label
    Friend WithEvents BTNYa As Button
    Friend WithEvents BTNCancel As Button
    Friend WithEvents LabelNamaBarang As Label
End Class
