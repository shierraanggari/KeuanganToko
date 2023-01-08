<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahBarang))
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
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(62, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(702, 84)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tambah Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(62, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(62, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(62, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(62, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(62, 331)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(62, 381)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(122, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tanggal Kadaluarsa"
        '
        'TxtNamaBarang
        '
        Me.TxtNamaBarang.Location = New System.Drawing.Point(210, 122)
        Me.TxtNamaBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNamaBarang.Name = "TxtNamaBarang"
        Me.TxtNamaBarang.Size = New System.Drawing.Size(554, 21)
        Me.TxtNamaBarang.TabIndex = 10
        '
        'ComboJenisBarang
        '
        Me.ComboJenisBarang.FormattingEnabled = True
        Me.ComboJenisBarang.Location = New System.Drawing.Point(210, 169)
        Me.ComboJenisBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboJenisBarang.Name = "ComboJenisBarang"
        Me.ComboJenisBarang.Size = New System.Drawing.Size(554, 23)
        Me.ComboJenisBarang.TabIndex = 11
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(210, 224)
        Me.TxtStok.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(554, 21)
        Me.TxtStok.TabIndex = 12
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(210, 278)
        Me.TxtHarga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(554, 21)
        Me.TxtHarga.TabIndex = 13
        '
        'DatePickTanggalMasuk
        '
        Me.DatePickTanggalMasuk.Location = New System.Drawing.Point(210, 327)
        Me.DatePickTanggalMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DatePickTanggalMasuk.Name = "DatePickTanggalMasuk"
        Me.DatePickTanggalMasuk.Size = New System.Drawing.Size(554, 21)
        Me.DatePickTanggalMasuk.TabIndex = 14
        '
        'DatePickTanggalKadaluarsa
        '
        Me.DatePickTanggalKadaluarsa.Location = New System.Drawing.Point(210, 377)
        Me.DatePickTanggalKadaluarsa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DatePickTanggalKadaluarsa.Name = "DatePickTanggalKadaluarsa"
        Me.DatePickTanggalKadaluarsa.Size = New System.Drawing.Size(554, 21)
        Me.DatePickTanggalKadaluarsa.TabIndex = 15
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTambah.Location = New System.Drawing.Point(210, 458)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(554, 33)
        Me.BtnTambah.TabIndex = 17
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Transparent
        Me.BtnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBatal.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnBatal.Location = New System.Drawing.Point(62, 458)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(142, 33)
        Me.BtnBatal.TabIndex = 18
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowItemReorder = True
        Me.MenuStrip1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NamaToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(835, 40)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NamaToolStripMenuItem
        '
        Me.NamaToolStripMenuItem.AutoSize = False
        Me.NamaToolStripMenuItem.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NamaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.NamaToolStripMenuItem.Image = CType(resources.GetObject("NamaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NamaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.NamaToolStripMenuItem.Name = "NamaToolStripMenuItem"
        Me.NamaToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.NamaToolStripMenuItem.Size = New System.Drawing.Size(122, 30)
        Me.NamaToolStripMenuItem.Text = "username"
        Me.NamaToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'TambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 521)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnBatal)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "TambahBarang"
        Me.Text = "Tambah Barang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents BtnBatal As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NamaToolStripMenuItem As ToolStripMenuItem
End Class
