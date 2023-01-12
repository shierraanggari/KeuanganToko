<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahPenjualan
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
        Me.CbIdBarang = New System.Windows.Forms.ComboBox()
        Me.DTMTanggalJual = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.NumberQTY = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbIdBarang
        '
        Me.CbIdBarang.FormattingEnabled = True
        Me.CbIdBarang.Location = New System.Drawing.Point(304, 88)
        Me.CbIdBarang.Name = "CbIdBarang"
        Me.CbIdBarang.Size = New System.Drawing.Size(182, 33)
        Me.CbIdBarang.TabIndex = 11
        '
        'DTMTanggalJual
        '
        Me.DTMTanggalJual.Location = New System.Drawing.Point(299, 250)
        Me.DTMTanggalJual.Name = "DTMTanggalJual"
        Me.DTMTanggalJual.Size = New System.Drawing.Size(300, 31)
        Me.DTMTanggalJual.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanggal Jual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Jumlah Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID Barang"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(329, 360)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(112, 52)
        Me.BtnTambah.TabIndex = 12
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'NumberQTY
        '
        Me.NumberQTY.Location = New System.Drawing.Point(301, 172)
        Me.NumberQTY.Name = "NumberQTY"
        Me.NumberQTY.Size = New System.Drawing.Size(180, 31)
        Me.NumberQTY.TabIndex = 13
        '
        'TambahPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumberQTY)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.CbIdBarang)
        Me.Controls.Add(Me.DTMTanggalJual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahPenjualan"
        Me.Text = "TambahPenjualan"
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbIdBarang As ComboBox
    Friend WithEvents DTMTanggalJual As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents NumberQTY As NumericUpDown
End Class
