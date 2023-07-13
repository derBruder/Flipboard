Imports System.ComponentModel

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
  End Sub



  Private Sub FlipboardCTL_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    paintMe

  End Sub
  Sub PaintMe()
    Try


      Dim sText As String = Chr(aktChar)

      Dim BMP As New Bitmap(Me.Width, Me.Height)
      Dim g As Graphics = Graphics.FromImage(BMP)
      g.Clear(BGColor)

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


      g.Dispose()
      Me.BackgroundImage = BMP
    Catch ex As Exception

    End Try
  End Sub
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
      PaintMe()
    End If
  End Sub
End Class
