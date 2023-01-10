<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBarangMasuk
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
        Me.CBNamaBarang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumberQTY = New System.Windows.Forms.NumericUpDown()
        Me.DTMasuk = New System.Windows.Forms.DateTimePicker()
        Me.BTNTambah = New System.Windows.Forms.Button()
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBNamaBarang
        '
        Me.CBNamaBarang.FormattingEnabled = True
        Me.CBNamaBarang.Location = New System.Drawing.Point(170, 164)
        Me.CBNamaBarang.Name = "CBNamaBarang"
        Me.CBNamaBarang.Size = New System.Drawing.Size(241, 28)
        Me.CBNamaBarang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tambah Barang Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Masuk"
        '
        'NumberQTY
        '
        Me.NumberQTY.Location = New System.Drawing.Point(349, 303)
        Me.NumberQTY.Name = "NumberQTY"
        Me.NumberQTY.Size = New System.Drawing.Size(62, 27)
        Me.NumberQTY.TabIndex = 5
        '
        'DTMasuk
        '
        Me.DTMasuk.Location = New System.Drawing.Point(171, 235)
        Me.DTMasuk.Name = "DTMasuk"
        Me.DTMasuk.Size = New System.Drawing.Size(240, 27)
        Me.DTMasuk.TabIndex = 6
        '
        'BTNTambah
        '
        Me.BTNTambah.Location = New System.Drawing.Point(206, 368)
        Me.BTNTambah.Name = "BTNTambah"
        Me.BTNTambah.Size = New System.Drawing.Size(94, 29)
        Me.BTNTambah.TabIndex = 7
        Me.BTNTambah.Text = "Tambah"
        Me.BTNTambah.UseVisualStyleBackColor = True
        '
        'AddBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.Controls.Add(Me.BTNTambah)
        Me.Controls.Add(Me.DTMasuk)
        Me.Controls.Add(Me.NumberQTY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBNamaBarang)
        Me.Name = "AddBarangMasuk"
        Me.Text = "AddBarangMasuk"
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBNamaBarang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumberQTY As NumericUpDown
    Friend WithEvents DTMasuk As DateTimePicker
    Friend WithEvents BTNTambah As Button
End Class
