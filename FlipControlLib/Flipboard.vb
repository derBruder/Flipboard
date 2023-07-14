Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView
Imports Microsoft.VisualBasic.Devices

Public Class FlipboardCTL
  Private aktChar As Byte
  Private _SollChar As Byte

  Public Property SollChar() As String
    Get
      Return Chr(_SollChar)
    End Get
    Set(ByVal value As String)
      _SollChar = Asc(value.Substring(0, 1))

    End Set
  End Property
  Private Sub FlipboardCTL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.BackColor = Color.Transparent
    Dim Flaptime As Integer = CInt(Rnd() * 40) + 80
    tmrBlaettern.Interval = Flaptime

    'My.Computer.Audio.Play(My.Resources.Resource1.Flap, AudioPlayMode.Background)
  End Sub



  Private Sub FlipboardCTL_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    PaintMe()

  End Sub
  Private Function GetRoundedPath(rect As Rectangle, radius As Single) As GraphicsPath
    Dim path As GraphicsPath = New GraphicsPath()
    Dim curveSize As Single = radius * 2.0F
    path.StartFigure()
    path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
    path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
    path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
    path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
    path.CloseFigure()
    Return path
  End Function


  Sub PaintMe()
    Try


      Dim sText As String = Chr(aktChar)

      Dim BMP As New Bitmap(Me.Width, Me.Height)
      Dim g As Graphics = Graphics.FromImage(BMP)
      Dim penBorder As Pen = New Pen(Color.Black, 4)
      Dim Brush1 = New SolidBrush(BGColor)
      g.Clear(Color.Transparent)

      Using roundPath As GraphicsPath = GetRoundedPath(Me.ClientRectangle, 10)
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.FillPath(Brush1, roundPath)
        g.DrawPath(penBorder, roundPath)
      End Using

      'g.Clear(BGColor)

      Dim myFont As Font
      Dim xSize As Single = 20
      Dim AproxStep As Single = 10
      Dim myFontMeasure As SizeF
      Do
        myFont = New Font("Arial Rounded MT", xSize, FontStyle.Bold)
        AproxStep /= 2
        myFontMeasure = g.MeasureString(sText, myFont)
        If myFontMeasure.Width > Me.Width * 1.3 Or myFontMeasure.Height > Me.Height * 1.3 Then
          xSize = xSize / (AproxStep + 1)
        Else
          If AproxStep < 1 Then Exit Do
          xSize = xSize * (AproxStep + 1)
        End If
      Loop


      Dim myBrush = New SolidBrush(FontColor)
      Dim mypoint = New Point((Me.Width - myFontMeasure.Width) / 2, (Me.Height - myFontMeasure.Height) / 2)
      g.DrawString(sText, myFont, myBrush, mypoint)
      g.DrawLine(penBorder, New Point(0, Me.Height / 2), New Point(Me.Width, Me.Height / 2))
      Dim y7 As Integer = Me.Height / 7
      Dim x11 As Integer = Me.Width / 11
      Dim recdraw As New Rectangle(0, y7 * 3, x11, y7)
      Dim linGrBrush As LinearGradientBrush = New LinearGradientBrush(recdraw, BriPro(150, BGColor), BriPro(50, BGColor), LinearGradientMode.ForwardDiagonal)
      g.FillRectangle(linGrBrush, recdraw)
      g.DrawRectangle(penBorder, recdraw)

      recdraw = New Rectangle(x11 * 10 - 2, y7 * 3, x11, y7)
      linGrBrush = New LinearGradientBrush(recdraw, BriPro(150, BGColor), BriPro(50, BGColor), LinearGradientMode.ForwardDiagonal)
      g.FillRectangle(linGrBrush, recdraw)
      g.DrawRectangle(penBorder, recdraw)


      g.Dispose()
      Me.BackgroundImage = BMP
    Catch ex As Exception

    End Try
  End Sub
  Private Function CheckCol(ByVal iVal As Integer) As Integer
    Dim CheckVal As Integer = iVal
    If CheckVal > 255 Then CheckVal = 255
    If CheckVal < 0 Then CheckVal = 0
    Return CheckVal
  End Function
  Private Function BriPro(iproz As Integer, OldColor As Color) As Color
    Dim cnew As Color
    Dim newVal As Integer
    Dim _r, _g, _b As Integer

    _r = CheckCol(OldColor.R / 100 * iproz)
    _g = CheckCol(OldColor.G / 100 * iproz)
    _b = CheckCol(OldColor.B / 100 * iproz)

    Return Color.FromArgb(_r, _g, _b)


  End Function

  Private _BGColor As Color
  Public Property BGColor() As Color
    Get
      Return _BGColor
    End Get
    Set(ByVal value As Color)
      _BGColor = value
    End Set
  End Property
  Private _FontColor As Color

  Public Sub New()

    ' Dieser Aufruf ist für den Designer erforderlich.
    InitializeComponent()

    ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    Me.DoubleBuffered = True
  End Sub

  Public Property FontColor() As Color
    Get
      Return _FontColor
    End Get
    Set(ByVal value As Color)
      _FontColor = value
    End Set
  End Property

  Private Sub tmrBlaettern_Tick(sender As Object, e As EventArgs) Handles tmrBlaettern.Tick
    If _SollChar > 127 Or _SollChar < 21 Then _SollChar = 63
    If _SollChar <> aktChar Then
      aktChar += 1
      If aktChar > 127 Then aktChar = 21
      My.Computer.Audio.Play(My.Resources.Resource1.Flap, AudioPlayMode.Background)



      PaintMe()
    End If
  End Sub
End Class
