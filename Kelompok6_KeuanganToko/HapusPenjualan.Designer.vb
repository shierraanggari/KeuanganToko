<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusPenjualan
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabID = New System.Windows.Forms.Label()
        Me.LabNamaBarang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(425, 326)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(203, 54)
        Me.BtnHapus.TabIndex = 0
        Me.BtnHapus.Text = "Hapus Penjualan"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tidak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hapus Data Penjualan ?"
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(372, 150)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(30, 25)
        Me.LabID.TabIndex = 3
        Me.LabID.Text = "ID"
        '
        'LabNamaBarang
        '
        Me.LabNamaBarang.AutoSize = True
        Me.LabNamaBarang.Location = New System.Drawing.Point(325, 227)
        Me.LabNamaBarang.Name = "LabNamaBarang"
        Me.LabNamaBarang.Size = New System.Drawing.Size(119, 25)
        Me.LabNamaBarang.TabIndex = 4
        Me.LabNamaBarang.Text = "Nama Barang"
        '
        'HapusPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabNamaBarang)
        Me.Controls.Add(Me.LabID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Name = "HapusPenjualan"
        Me.Text = "HapusPenjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabID As Label
    Friend WithEvents LabNamaBarang As Label
End Class
