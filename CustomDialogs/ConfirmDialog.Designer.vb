<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmDialog
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 111)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure you want to close?"
        '
        'NoButton
        '
        Me.NoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.NoButton.Location = New System.Drawing.Point(244, 141)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 1
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'YesButton
        '
        Me.YesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.YesButton.Location = New System.Drawing.Point(163, 141)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 23)
        Me.YesButton.TabIndex = 2
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'ConfirmDialog
        '
        Me.AcceptButton = Me.YesButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NoButton
        Me.ClientSize = New System.Drawing.Size(332, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ConfirmDialog"
        Me.Text = "ConfirmDialog"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NoButton As Button
    Friend WithEvents YesButton As Button
End Class
