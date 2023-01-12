<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Penjualan
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DataGridViewPenjualan = New System.Windows.Forms.DataGridView()
        Me.ID_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_masuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(143, 456)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(112, 34)
        Me.BtnTambah.TabIndex = 13
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(387, 456)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.BtnUpdate.TabIndex = 14
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(656, 456)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(112, 34)
        Me.BtnDelete.TabIndex = 15
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'DataGridViewPenjualan
        '
        Me.DataGridViewPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Barang, Me.jumlah_Barang, Me.tgl_masuk})
        Me.DataGridViewPenjualan.Location = New System.Drawing.Point(143, 12)
        Me.DataGridViewPenjualan.Name = "DataGridViewPenjualan"
        Me.DataGridViewPenjualan.RowHeadersWidth = 62
        Me.DataGridViewPenjualan.RowTemplate.Height = 33
        Me.DataGridViewPenjualan.Size = New System.Drawing.Size(625, 423)
        Me.DataGridViewPenjualan.TabIndex = 16
        '
        'ID_Barang
        '
        Me.ID_Barang.HeaderText = "ID_Barang"
        Me.ID_Barang.MinimumWidth = 8
        Me.ID_Barang.Name = "ID_Barang"
        Me.ID_Barang.Width = 150
        '
        'jumlah_Barang
        '
        Me.jumlah_Barang.HeaderText = "jumlah barang"
        Me.jumlah_Barang.MinimumWidth = 8
        Me.jumlah_Barang.Name = "jumlah_Barang"
        Me.jumlah_Barang.Width = 150
        '
        'tgl_masuk
        '
        Me.tgl_masuk.HeaderText = "tgl_masuk"
        Me.tgl_masuk.MinimumWidth = 8
        Me.tgl_masuk.Name = "tgl_masuk"
        Me.tgl_masuk.Width = 150
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 546)
        Me.Controls.Add(Me.DataGridViewPenjualan)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnTambah)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Penjualan"
        Me.Text = "Penjualan"
        CType(Me.DataGridViewPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DataGridViewPenjualan As DataGridView
    Friend WithEvents ID_Barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_Barang As DataGridViewTextBoxColumn
    Friend WithEvents tgl_masuk As DataGridViewTextBoxColumn
End Class
