<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePenjualan
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBNamaBarang = New System.Windows.Forms.ComboBox()
        Me.DTMasuk = New System.Windows.Forms.DateTimePicker()
        Me.NumberQTY = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(123, 373)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(536, 47)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "Update Penjualan"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode"
        '
        'LblKode
        '
        Me.LblKode.AutoSize = True
        Me.LblKode.Location = New System.Drawing.Point(123, 95)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(30, 25)
        Me.LblKode.TabIndex = 2
        Me.LblKode.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jumlah"
        '
        'CBNamaBarang
        '
        Me.CBNamaBarang.FormattingEnabled = True
        Me.CBNamaBarang.Location = New System.Drawing.Point(227, 169)
        Me.CBNamaBarang.Name = "CBNamaBarang"
        Me.CBNamaBarang.Size = New System.Drawing.Size(370, 33)
        Me.CBNamaBarang.TabIndex = 6
        '
        'DTMasuk
        '
        Me.DTMasuk.Location = New System.Drawing.Point(224, 232)
        Me.DTMasuk.Name = "DTMasuk"
        Me.DTMasuk.Size = New System.Drawing.Size(300, 31)
        Me.DTMasuk.TabIndex = 7
        '
        'NumberQTY
        '
        Me.NumberQTY.Location = New System.Drawing.Point(221, 310)
        Me.NumberQTY.Name = "NumberQTY"
        Me.NumberQTY.Size = New System.Drawing.Size(84, 31)
        Me.NumberQTY.TabIndex = 8
        '
        'UpdatePenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumberQTY)
        Me.Controls.Add(Me.DTMasuk)
        Me.Controls.Add(Me.CBNamaBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Name = "UpdatePenjualan"
        Me.Text = "UpdatePenjualan"
        CType(Me.NumberQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblKode As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CBNamaBarang As ComboBox
    Friend WithEvents DTMasuk As DateTimePicker
    Friend WithEvents NumberQTY As NumericUpDown
End Class
