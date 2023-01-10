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
        Me.CBNamaBarang.Location = New System.Drawing.Point(276, 262)
        Me.CBNamaBarang.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.CBNamaBarang.Name = "CBNamaBarang"
        Me.CBNamaBarang.Size = New System.Drawing.Size(389, 40)
        Me.CBNamaBarang.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tambah Barang Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 267)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 485)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 376)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Masuk"
        '
        'NumberQTY
        '
        Me.NumberQTY.Location = New System.Drawing.Point(567, 485)
        Me.NumberQTY.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.NumberQTY.Name = "NumberQTY"
        Me.NumberQTY.Size = New System.Drawing.Size(101, 39)
        Me.NumberQTY.TabIndex = 5
        '
        'DTMasuk
        '
        Me.DTMasuk.Location = New System.Drawing.Point(278, 376)
        Me.DTMasuk.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DTMasuk.Name = "DTMasuk"
        Me.DTMasuk.Size = New System.Drawing.Size(388, 39)
        Me.DTMasuk.TabIndex = 6
        '
        'BTNTambah
        '
        Me.BTNTambah.Location = New System.Drawing.Point(335, 589)
        Me.BTNTambah.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BTNTambah.Name = "BTNTambah"
        Me.BTNTambah.Size = New System.Drawing.Size(153, 46)
        Me.BTNTambah.TabIndex = 7
        Me.BTNTambah.Text = "Tambah"
        Me.BTNTambah.UseVisualStyleBackColor = True
        '
        'AddBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 720)
        Me.Controls.Add(Me.BTNTambah)
        Me.Controls.Add(Me.DTMasuk)
        Me.Controls.Add(Me.NumberQTY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBNamaBarang)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
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
