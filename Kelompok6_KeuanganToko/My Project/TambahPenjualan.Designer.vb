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
        Me.ComboIdBarang = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerTanggalJual = New System.Windows.Forms.DateTimePicker()
        Me.TxtJumlahBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboIdBarang
        '
        Me.ComboIdBarang.FormattingEnabled = True
        Me.ComboIdBarang.Location = New System.Drawing.Point(304, 88)
        Me.ComboIdBarang.Name = "ComboIdBarang"
        Me.ComboIdBarang.Size = New System.Drawing.Size(182, 33)
        Me.ComboIdBarang.TabIndex = 11
        '
        'DateTimePickerTanggalJual
        '
        Me.DateTimePickerTanggalJual.Location = New System.Drawing.Point(299, 250)
        Me.DateTimePickerTanggalJual.Name = "DateTimePickerTanggalJual"
        Me.DateTimePickerTanggalJual.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePickerTanggalJual.TabIndex = 10
        '
        'TxtJumlahBarang
        '
        Me.TxtJumlahBarang.Location = New System.Drawing.Point(292, 161)
        Me.TxtJumlahBarang.Name = "TxtJumlahBarang"
        Me.TxtJumlahBarang.Size = New System.Drawing.Size(347, 31)
        Me.TxtJumlahBarang.TabIndex = 9
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
        Me.BtnTambah.Size = New System.Drawing.Size(112, 34)
        Me.BtnTambah.TabIndex = 12
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TambahPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.ComboIdBarang)
        Me.Controls.Add(Me.DateTimePickerTanggalJual)
        Me.Controls.Add(Me.TxtJumlahBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahPenjualan"
        Me.Text = "TambahPenjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboIdBarang As ComboBox
    Friend WithEvents DateTimePickerTanggalJual As DateTimePicker
    Friend WithEvents TxtJumlahBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
End Class
