<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusJenisBarang
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
        Me.LblHapusJenis = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.BtnHapusJenis = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblHapusJenis
        '
        Me.LblHapusJenis.AutoSize = True
        Me.LblHapusJenis.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHapusJenis.Location = New System.Drawing.Point(25, 23)
        Me.LblHapusJenis.Name = "LblHapusJenis"
        Me.LblHapusJenis.Size = New System.Drawing.Size(204, 30)
        Me.LblHapusJenis.TabIndex = 0
        Me.LblHapusJenis.Text = "Hapus Jenis Barang"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(110, 71)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(18, 15)
        Me.LblID.TabIndex = 1
        Me.LblID.Text = "ID"
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.Location = New System.Drawing.Point(81, 107)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(72, 15)
        Me.LblJenis.TabIndex = 2
        Me.LblJenis.Text = "Jenis Barang"
        '
        'BtnHapusJenis
        '
        Me.BtnHapusJenis.Location = New System.Drawing.Point(25, 157)
        Me.BtnHapusJenis.Name = "BtnHapusJenis"
        Me.BtnHapusJenis.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusJenis.TabIndex = 3
        Me.BtnHapusJenis.Text = "Hapus"
        Me.BtnHapusJenis.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(144, 157)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 4
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'FormHapusJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 214)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapusJenis)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.LblHapusJenis)
        Me.Name = "FormHapusJenisBarang"
        Me.Text = "FormHapusJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHapusJenis As Label
    Friend WithEvents LblID As Label
    Friend WithEvents LblJenis As Label
    Friend WithEvents BtnHapusJenis As Button
    Friend WithEvents BtnBatal As Button
End Class
