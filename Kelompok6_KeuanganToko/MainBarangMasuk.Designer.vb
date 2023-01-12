<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainBarangMasuk
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
        Me.GridBarangMasuk = New System.Windows.Forms.DataGridView()
        Me.BTNTambah = New System.Windows.Forms.Button()
        Me.BTNHapus = New System.Windows.Forms.Button()
        Me.BTNEdit = New System.Windows.Forms.Button()
        CType(Me.GridBarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridBarangMasuk
        '
        Me.GridBarangMasuk.AllowUserToAddRows = False
        Me.GridBarangMasuk.AllowUserToDeleteRows = False
        Me.GridBarangMasuk.AllowUserToResizeColumns = False
        Me.GridBarangMasuk.AllowUserToResizeRows = False
        Me.GridBarangMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridBarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBarangMasuk.Location = New System.Drawing.Point(81, 98)
        Me.GridBarangMasuk.MultiSelect = False
        Me.GridBarangMasuk.Name = "GridBarangMasuk"
        Me.GridBarangMasuk.ReadOnly = True
        Me.GridBarangMasuk.RowHeadersWidth = 51
        Me.GridBarangMasuk.RowTemplate.Height = 29
        Me.GridBarangMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridBarangMasuk.Size = New System.Drawing.Size(729, 201)
        Me.GridBarangMasuk.TabIndex = 0
        '
        'BTNTambah
        '
        Me.BTNTambah.Location = New System.Drawing.Point(81, 353)
        Me.BTNTambah.Name = "BTNTambah"
        Me.BTNTambah.Size = New System.Drawing.Size(181, 29)
        Me.BTNTambah.TabIndex = 1
        Me.BTNTambah.Text = "Tambah"
        Me.BTNTambah.UseVisualStyleBackColor = True
        '
        'BTNHapus
        '
        Me.BTNHapus.Location = New System.Drawing.Point(629, 353)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(181, 29)
        Me.BTNHapus.TabIndex = 2
        Me.BTNHapus.Text = "Hapus"
        Me.BTNHapus.UseVisualStyleBackColor = True
        '
        'BTNEdit
        '
        Me.BTNEdit.Location = New System.Drawing.Point(354, 353)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(181, 29)
        Me.BTNEdit.TabIndex = 3
        Me.BTNEdit.Text = "Edit"
        Me.BTNEdit.UseVisualStyleBackColor = True
        '
        'MainBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 450)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.BTNTambah)
        Me.Controls.Add(Me.GridBarangMasuk)
        Me.Name = "MainBarangMasuk"
        Me.Text = "MainBarangMasuk"
        CType(Me.GridBarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridBarangMasuk As DataGridView
    Friend WithEvents BTNTambah As Button
    Friend WithEvents BTNHapus As Button
    Friend WithEvents BTNEdit As Button
End Class
