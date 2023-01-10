<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBarangMasuk
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
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.DTMasuk = New System.Windows.Forms.DateTimePicker()
        Me.NumberQTY = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBNamaBarang = New System.Windows.Forms.ComboBox()
        Me.label40 = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNEdit
        '
        Me.BTNEdit.Location = New System.Drawing.Point(233, 370)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(94, 29)
        Me.BTNEdit.TabIndex = 15
        Me.BTNEdit.Text = "Edit"
        Me.BTNEdit.UseVisualStyleBackColor = True
        '
        'DTMasuk
        '
        Me.DTMasuk.CustomFormat = "dd/MM/yyyy"
        Me.DTMasuk.Location = New System.Drawing.Point(198, 237)
        Me.DTMasuk.Name = "DTMasuk"
        Me.DTMasuk.Size = New System.Drawing.Size(240, 27)
        Me.DTMasuk.TabIndex = 14
        '
        'NumberQTY
        '
        Me.NumberQTY.Location = New System.Drawing.Point(376, 305)
        Me.NumberQTY.Name = "NumberQTY"
        Me.NumberQTY.Size = New System.Drawing.Size(62, 27)
        Me.NumberQTY.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tanggal Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Edit Barang Masuk"
        '
        'CBNamaBarang
        '
        Me.CBNamaBarang.FormattingEnabled = True
        Me.CBNamaBarang.Location = New System.Drawing.Point(197, 166)
        Me.CBNamaBarang.Name = "CBNamaBarang"
        Me.CBNamaBarang.Size = New System.Drawing.Size(241, 28)
        Me.CBNamaBarang.TabIndex = 8
        '
        'label40
        '
        Me.label40.AutoSize = True
        Me.label40.Location = New System.Drawing.Point(58, 125)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(47, 20)
        Me.label40.TabIndex = 16
        Me.label40.Text = "Kode:"
        '
        'LblKode
        '
        Me.LblKode.AutoSize = True
        Me.LblKode.Location = New System.Drawing.Point(197, 125)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(24, 20)
        Me.LblKode.TabIndex = 17
        Me.LblKode.Text = "ID"
        '
        'EditBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 450)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.label40)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.DTMasuk)
        Me.Controls.Add(Me.NumberQTY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBNamaBarang)
        Me.Name = "EditBarangMasuk"
        Me.Text = "EditBarangMasuk"
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNEdit As Button
    Friend WithEvents DTMasuk As DateTimePicker
    Friend WithEvents NumberQTY As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBNamaBarang As ComboBox
    Friend WithEvents label40 As Label
    Friend WithEvents LblKode As Label
End Class
