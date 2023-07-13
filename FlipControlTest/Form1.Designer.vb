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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flipboardtest))
    Me.Flip1 = New FlipControlLib.FlipboardCTL()
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Flip2 = New FlipControlLib.FlipboardCTL()
    Me.Flip3 = New FlipControlLib.FlipboardCTL()
    Me.FBG1 = New FlipControlLib.FlipboardGroup()
    Me.SuspendLayout()
    '
    'Flip1
    '
    Me.Flip1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Flip1.BackColor = System.Drawing.Color.Transparent
    Me.Flip1.BackgroundImage = CType(resources.GetObject("Flip1.BackgroundImage"), System.Drawing.Image)
    Me.Flip1.BGColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Flip1.FontColor = System.Drawing.Color.Cyan
    Me.Flip1.Location = New System.Drawing.Point(92, 340)
    Me.Flip1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.Flip1.Name = "Flip1"
    Me.Flip1.Size = New System.Drawing.Size(153, 187)
    Me.Flip1.SollChar = "A"
    Me.Flip1.TabIndex = 0
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(92, 251)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(153, 37)
    Me.Button1.TabIndex = 3
    Me.Button1.Text = "Abcd"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(253, 251)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(153, 37)
    Me.Button2.TabIndex = 4
    Me.Button2.Text = "Hello"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(412, 251)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(153, 37)
    Me.Button3.TabIndex = 5
    Me.Button3.Text = "Test"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Flip2
    '
    Me.Flip2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Flip2.BackColor = System.Drawing.Color.Transparent
    Me.Flip2.BackgroundImage = CType(resources.GetObject("Flip2.BackgroundImage"), System.Drawing.Image)
    Me.Flip2.BGColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Flip2.FontColor = System.Drawing.Color.Cyan
    Me.Flip2.Location = New System.Drawing.Point(253, 340)
    Me.Flip2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.Flip2.Name = "Flip2"
    Me.Flip2.Size = New System.Drawing.Size(153, 187)
    Me.Flip2.SollChar = "B"
    Me.Flip2.TabIndex = 1
    '
    'Flip3
    '
    Me.Flip3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Flip3.BackColor = System.Drawing.Color.Transparent
    Me.Flip3.BackgroundImage = CType(resources.GetObject("Flip3.BackgroundImage"), System.Drawing.Image)
    Me.Flip3.BGColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.Flip3.FontColor = System.Drawing.Color.Cyan
    Me.Flip3.Location = New System.Drawing.Point(414, 340)
    Me.Flip3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.Flip3.Name = "Flip3"
    Me.Flip3.Size = New System.Drawing.Size(153, 187)
    Me.Flip3.SollChar = "C"
    Me.Flip3.TabIndex = 2
    '
    'FBG1
    '
    Me.FBG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.FBG1.BackColor = System.Drawing.Color.Teal
    Me.FBG1.BGColor = System.Drawing.Color.Empty
    Me.FBG1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.FBG1.Location = New System.Drawing.Point(13, 12)
    Me.FBG1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.FBG1.Name = "FBG1"
    Me.FBG1.NumberOfFlipsX = 5
    Me.FBG1.PartBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.FBG1.Size = New System.Drawing.Size(867, 208)
    Me.FBG1.TabIndex = 0
    Me.FBG1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    '
    'Flipboardtest
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(893, 595)
    Me.Controls.Add(Me.FBG1)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.Flip3)
    Me.Controls.Add(Me.Flip2)
    Me.Controls.Add(Me.Flip1)
    Me.Name = "Flipboardtest"
    Me.Text = "Flipboardtest"
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Flip1 As FlipboardCTL
  Friend WithEvents ColorDialog1 As ColorDialog
  Friend WithEvents Button1 As Button
  Friend WithEvents Button2 As Button
  Friend WithEvents Button3 As Button
  Friend WithEvents Flip2 As FlipboardCTL
  Friend WithEvents Flip3 As FlipboardCTL
  Friend WithEvents FBG1 As FlipboardGroup
End Class
