<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahJenisBarang
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
        Me.TxtJenisBarang = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtJenisBarang
        '
        Me.TxtJenisBarang.Location = New System.Drawing.Point(12, 51)
        Me.TxtJenisBarang.Name = "TxtJenisBarang"
        Me.TxtJenisBarang.Size = New System.Drawing.Size(206, 23)
        Me.TxtJenisBarang.TabIndex = 2
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(12, 89)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jenis Barang"
        '
        'FormTambahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 125)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtJenisBarang)
        Me.Name = "FormTambahJenisBarang"
        Me.Text = "FormTambahJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtJenisBarang As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Label1 As Label
End Class
