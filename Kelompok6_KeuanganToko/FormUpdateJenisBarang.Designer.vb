<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateJenisBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUpdateJenis = New System.Windows.Forms.TextBox()
        Me.BtnUpdateJenis = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblVarID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Jenis Barang"
        '
        'TxtUpdateJenis
        '
        Me.TxtUpdateJenis.Location = New System.Drawing.Point(12, 76)
        Me.TxtUpdateJenis.Name = "TxtUpdateJenis"
        Me.TxtUpdateJenis.Size = New System.Drawing.Size(210, 23)
        Me.TxtUpdateJenis.TabIndex = 1
        '
        'BtnUpdateJenis
        '
        Me.BtnUpdateJenis.Location = New System.Drawing.Point(15, 116)
        Me.BtnUpdateJenis.Name = "BtnUpdateJenis"
        Me.BtnUpdateJenis.Size = New System.Drawing.Size(64, 24)
        Me.BtnUpdateJenis.TabIndex = 2
        Me.BtnUpdateJenis.Text = "Update"
        Me.BtnUpdateJenis.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Jenis Barang :"
        '
        'LblVarID
        '
        Me.LblVarID.AutoSize = True
        Me.LblVarID.Location = New System.Drawing.Point(110, 50)
        Me.LblVarID.Name = "LblVarID"
        Me.LblVarID.Size = New System.Drawing.Size(18, 15)
        Me.LblVarID.TabIndex = 4
        Me.LblVarID.Text = "ID"
        '
        'FormUpdateJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 152)
        Me.Controls.Add(Me.LblVarID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnUpdateJenis)
        Me.Controls.Add(Me.TxtUpdateJenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUpdateJenisBarang"
        Me.Text = "FormUpdateJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUpdateJenis As TextBox
    Friend WithEvents BtnUpdateJenis As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblVarID As Label
End Class
