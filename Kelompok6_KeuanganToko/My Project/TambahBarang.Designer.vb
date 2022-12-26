<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahBarang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNamaBarang = New System.Windows.Forms.TextBox()
        Me.ComboJenisBarang = New System.Windows.Forms.ComboBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.DatePickTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.DatePickTanggalKadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(180, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tambah Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(32, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(32, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(32, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(32, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(32, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(32, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tanggal Kadaluarsa"
        '
        'TxtNamaBarang
        '
        Me.TxtNamaBarang.Location = New System.Drawing.Point(180, 97)
        Me.TxtNamaBarang.Name = "TxtNamaBarang"
        Me.TxtNamaBarang.Size = New System.Drawing.Size(315, 21)
        Me.TxtNamaBarang.TabIndex = 10
        '
        'ComboJenisBarang
        '
        Me.ComboJenisBarang.FormattingEnabled = True
        Me.ComboJenisBarang.Location = New System.Drawing.Point(180, 146)
        Me.ComboJenisBarang.Name = "ComboJenisBarang"
        Me.ComboJenisBarang.Size = New System.Drawing.Size(315, 23)
        Me.ComboJenisBarang.TabIndex = 11
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(180, 199)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(315, 21)
        Me.TxtStok.TabIndex = 12
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(180, 250)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(315, 21)
        Me.TxtHarga.TabIndex = 13
        '
        'DatePickTanggalMasuk
        '
        Me.DatePickTanggalMasuk.Location = New System.Drawing.Point(180, 298)
        Me.DatePickTanggalMasuk.Name = "DatePickTanggalMasuk"
        Me.DatePickTanggalMasuk.Size = New System.Drawing.Size(315, 21)
        Me.DatePickTanggalMasuk.TabIndex = 14
        '
        'DatePickTanggalKadaluarsa
        '
        Me.DatePickTanggalKadaluarsa.Location = New System.Drawing.Point(180, 349)
        Me.DatePickTanggalKadaluarsa.Name = "DatePickTanggalKadaluarsa"
        Me.DatePickTanggalKadaluarsa.Size = New System.Drawing.Size(315, 21)
        Me.DatePickTanggalKadaluarsa.TabIndex = 15
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.Location = New System.Drawing.Point(215, 454)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(130, 40)
        Me.BtnTambah.TabIndex = 16
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 521)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DatePickTanggalKadaluarsa)
        Me.Controls.Add(Me.DatePickTanggalMasuk)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.ComboJenisBarang)
        Me.Controls.Add(Me.TxtNamaBarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "TambahBarang"
        Me.Text = "Tambah Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNamaBarang As TextBox
    Friend WithEvents ComboJenisBarang As ComboBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents DatePickTanggalMasuk As DateTimePicker
    Friend WithEvents DatePickTanggalKadaluarsa As DateTimePicker
    Friend WithEvents BtnTambah As Button
End Class
