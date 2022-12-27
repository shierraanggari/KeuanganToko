<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.LblIdJenis = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.LblTM = New System.Windows.Forms.Label()
        Me.LblTK = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(925, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisBarangToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.BarangMasukToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'JenisBarangToolStripMenuItem
        '
        Me.JenisBarangToolStripMenuItem.Name = "JenisBarangToolStripMenuItem"
        Me.JenisBarangToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.JenisBarangToolStripMenuItem.Text = "Jenis Barang"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(12, 75)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.RowTemplate.Height = 25
        Me.DataGridViewBarang.Size = New System.Drawing.Size(810, 385)
        Me.DataGridViewBarang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(325, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.Location = New System.Drawing.Point(269, 474)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(100, 33)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.Location = New System.Drawing.Point(375, 474)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 33)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Ubah"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.Location = New System.Drawing.Point(481, 474)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(100, 33)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(851, 125)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(45, 15)
        Me.LblNama.TabIndex = 18
        Me.LblNama.Text = "Label8"
        '
        'LblIdJenis
        '
        Me.LblIdJenis.AutoSize = True
        Me.LblIdJenis.Location = New System.Drawing.Point(851, 158)
        Me.LblIdJenis.Name = "LblIdJenis"
        Me.LblIdJenis.Size = New System.Drawing.Size(45, 15)
        Me.LblIdJenis.TabIndex = 19
        Me.LblIdJenis.Text = "Label8"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Location = New System.Drawing.Point(851, 190)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(45, 15)
        Me.LblStok.TabIndex = 20
        Me.LblStok.Text = "Label8"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.Location = New System.Drawing.Point(851, 221)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(45, 15)
        Me.LblHarga.TabIndex = 21
        Me.LblHarga.Text = "Label8"
        '
        'LblTM
        '
        Me.LblTM.AutoSize = True
        Me.LblTM.Location = New System.Drawing.Point(851, 253)
        Me.LblTM.Name = "LblTM"
        Me.LblTM.Size = New System.Drawing.Size(45, 15)
        Me.LblTM.TabIndex = 22
        Me.LblTM.Text = "Label8"
        '
        'LblTK
        '
        Me.LblTK.AutoSize = True
        Me.LblTK.Location = New System.Drawing.Point(851, 286)
        Me.LblTK.Name = "LblTK"
        Me.LblTK.Size = New System.Drawing.Size(45, 15)
        Me.LblTK.TabIndex = 23
        Me.LblTK.Text = "Label8"
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 521)
        Me.Controls.Add(Me.LblTK)
        Me.Controls.Add(Me.LblTM)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.LblIdJenis)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewBarang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Barang"
        Me.Text = "Barang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JenisBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblNama As Label
    Friend WithEvents LblIdJenis As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents LblHarga As Label
    Friend WithEvents LblTM As Label
    Friend WithEvents LblTK As Label
End Class
