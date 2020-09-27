<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCD
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
        Me.LblHIV = New System.Windows.Forms.Label()
        Me.btnTB = New System.Windows.Forms.Label()
        Me.lblMalaria = New System.Windows.Forms.Label()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblHIV
        '
        Me.LblHIV.AutoSize = True
        Me.LblHIV.Location = New System.Drawing.Point(128, 26)
        Me.LblHIV.Name = "LblHIV"
        Me.LblHIV.Size = New System.Drawing.Size(37, 20)
        Me.LblHIV.TabIndex = 0
        Me.LblHIV.Text = "HIV"
        '
        'btnTB
        '
        Me.btnTB.AutoSize = True
        Me.btnTB.Location = New System.Drawing.Point(937, 26)
        Me.btnTB.Name = "btnTB"
        Me.btnTB.Size = New System.Drawing.Size(29, 20)
        Me.btnTB.TabIndex = 1
        Me.btnTB.Text = "TB"
        '
        'lblMalaria
        '
        Me.lblMalaria.AutoSize = True
        Me.lblMalaria.Location = New System.Drawing.Point(492, 26)
        Me.lblMalaria.Name = "lblMalaria"
        Me.lblMalaria.Size = New System.Drawing.Size(60, 20)
        Me.lblMalaria.TabIndex = 2
        Me.lblMalaria.Text = "Malaria"
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(857, 67)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(190, 39)
        Me.btnInit.TabIndex = 3
        Me.btnInit.Text = "Enter details"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(857, 131)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(190, 39)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display info"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(799, 185)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(296, 235)
        Me.txtDisplay.TabIndex = 5
        '
        'frmCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 563)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.lblMalaria)
        Me.Controls.Add(Me.btnTB)
        Me.Controls.Add(Me.LblHIV)
        Me.Name = "frmCD"
        Me.Text = "Combat Diseases"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHIV As Label
    Friend WithEvents btnTB As Label
    Friend WithEvents lblMalaria As Label
    Friend WithEvents btnInit As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtDisplay As TextBox
End Class
