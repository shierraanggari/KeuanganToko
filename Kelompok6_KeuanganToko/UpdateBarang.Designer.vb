<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateBarang))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.DatePickTanggalKadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.DatePickTanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.ComboJenisBarang = New System.Windows.Forms.ComboBox()
        Me.TxtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MenuStrip1.TabIndex = 35
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
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Transparent
        Me.BtnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBatal.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnBatal.Location = New System.Drawing.Point(62, 459)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(142, 33)
        Me.BtnBatal.TabIndex = 34
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'DatePickTanggalKadaluarsa
        '
        Me.DatePickTanggalKadaluarsa.Location = New System.Drawing.Point(210, 392)
        Me.DatePickTanggalKadaluarsa.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DatePickTanggalKadaluarsa.Name = "DatePickTanggalKadaluarsa"
        Me.DatePickTanggalKadaluarsa.Size = New System.Drawing.Size(554, 22)
        Me.DatePickTanggalKadaluarsa.TabIndex = 32
        '
        'DatePickTanggalMasuk
        '
        Me.DatePickTanggalMasuk.Location = New System.Drawing.Point(210, 342)
        Me.DatePickTanggalMasuk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DatePickTanggalMasuk.Name = "DatePickTanggalMasuk"
        Me.DatePickTanggalMasuk.Size = New System.Drawing.Size(554, 22)
        Me.DatePickTanggalMasuk.TabIndex = 31
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(210, 293)
        Me.TxtHarga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(554, 22)
        Me.TxtHarga.TabIndex = 30
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(210, 239)
        Me.TxtStok.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(554, 22)
        Me.TxtStok.TabIndex = 29
        '
        'ComboJenisBarang
        '
        Me.ComboJenisBarang.FormattingEnabled = True
        Me.ComboJenisBarang.Location = New System.Drawing.Point(210, 184)
        Me.ComboJenisBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboJenisBarang.Name = "ComboJenisBarang"
        Me.ComboJenisBarang.Size = New System.Drawing.Size(554, 24)
        Me.ComboJenisBarang.TabIndex = 28
        '
        'TxtNamaBarang
        '
        Me.TxtNamaBarang.Location = New System.Drawing.Point(210, 137)
        Me.TxtNamaBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtNamaBarang.Name = "TxtNamaBarang"
        Me.TxtNamaBarang.Size = New System.Drawing.Size(554, 22)
        Me.TxtNamaBarang.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(62, 396)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(122, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Tanggal Kadaluarsa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(62, 346)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(62, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(62, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(62, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(62, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(62, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(702, 94)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Ubah Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUpdate.Location = New System.Drawing.Point(210, 459)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(554, 33)
        Me.BtnUpdate.TabIndex = 36
        Me.BtnUpdate.Text = "Simpan"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'UpdateBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 521)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnBatal)
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
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "UpdateBarang"
        Me.Text = "UpdateBarang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdate As Button
    Friend WithEvents DatePickTanggalKadaluarsa As DateTimePicker
    Friend WithEvents DatePickTanggalMasuk As DateTimePicker
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents ComboJenisBarang As ComboBox
    Friend WithEvents TxtNamaBarang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnBatal As Button
End Class
