Imports FlipControlLib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Flipboardtest
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.Flip1 = New FlipControlLib.FlipboardCTL()
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.Flipboardctl1 = New FlipControlLib.FlipboardCTL()
    Me.SuspendLayout()
    '
    'Flip1
    '
    Me.Flip1.Location = New System.Drawing.Point(92, 12)
    Me.Flip1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.Flip1.Name = "Flip1"
    Me.Flip1.Size = New System.Drawing.Size(139, 248)
    Me.Flip1.TabIndex = 0
    '
    'Flipboardctl1
    '
    Me.Flipboardctl1.Location = New System.Drawing.Point(252, 12)
    Me.Flipboardctl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.Flipboardctl1.Name = "Flipboardctl1"
    Me.Flipboardctl1.Size = New System.Drawing.Size(139, 248)
    Me.Flipboardctl1.TabIndex = 1
    '
    'Flipboardtest
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.Flipboardctl1)
    Me.Controls.Add(Me.Flip1)
    Me.Name = "Flipboardtest"
    Me.Text = "Flipboardtest"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Flip1 As FlipboardCTL
  Friend WithEvents ColorDialog1 As ColorDialog
  Friend WithEvents Flipboardctl1 As FlipboardCTL
End Class
