<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuBarangMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuJenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.NamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuBarangMasuk, Me.ToolStripMenuPenjualan, Me.ToolStripMenuJenisBarang, Me.NamaToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuBarangMasuk
        '
        Me.ToolStripMenuBarangMasuk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuBarangMasuk.AutoSize = False
        Me.ToolStripMenuBarangMasuk.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuBarangMasuk.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuBarangMasuk.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripMenuBarangMasuk.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.ToolStripMenuBarangMasuk.Name = "ToolStripMenuBarangMasuk"
        Me.ToolStripMenuBarangMasuk.Size = New System.Drawing.Size(122, 30)
        Me.ToolStripMenuBarangMasuk.Text = "Barang Masuk"
        '
        'ToolStripMenuPenjualan
        '
        Me.ToolStripMenuPenjualan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuPenjualan.AutoSize = False
        Me.ToolStripMenuPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuPenjualan.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuPenjualan.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripMenuPenjualan.Name = "ToolStripMenuPenjualan"
        Me.ToolStripMenuPenjualan.Size = New System.Drawing.Size(122, 30)
        Me.ToolStripMenuPenjualan.Text = "Penjualan"
        '
        'ToolStripMenuJenisBarang
        '
        Me.ToolStripMenuJenisBarang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuJenisBarang.AutoSize = False
        Me.ToolStripMenuJenisBarang.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuJenisBarang.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ToolStripMenuJenisBarang.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStripMenuJenisBarang.Name = "ToolStripMenuJenisBarang"
        Me.ToolStripMenuJenisBarang.Size = New System.Drawing.Size(122, 30)
        Me.ToolStripMenuJenisBarang.Text = "Jenis Barang"
        '
        'NamaToolStripMenuItem
        '
        Me.NamaToolStripMenuItem.AutoSize = False
        Me.NamaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
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
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBarang.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridViewBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(12, 77)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewBarang.RowHeadersWidth = 50
        Me.DataGridViewBarang.RowTemplate.Height = 25
        Me.DataGridViewBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridViewBarang.Size = New System.Drawing.Size(810, 380)
        Me.DataGridViewBarang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Heebo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(0, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(212, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.ForeColor = System.Drawing.Color.Transparent
        Me.BtnTambah.Location = New System.Drawing.Point(722, 473)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(100, 33)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.Location = New System.Drawing.Point(118, 473)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(100, 33)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Ubah"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Heebo", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnHapus.Location = New System.Drawing.Point(12, 473)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(100, 33)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(834, 521)
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

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuBarangMasuk As ToolStripMenuItem
    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents NamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuJenisBarang As ToolStripMenuItem
    Friend WithEvents ToolStripMenuPenjualan As ToolStripMenuItem
End Class
