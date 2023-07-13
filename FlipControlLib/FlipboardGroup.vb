Imports System.Data.OleDb
Imports System.Globalization

Public Class FlipboardGroup
  Private ColFlips As List(Of FlipboardCTL)

  Private _OldNuberOfFlipsX As Integer
  Private _NumberOfFlipsX As Integer = 1
  Public Property NumberOfFlipsX() As Integer
    Get
      Return _NumberOfFlipsX
    End Get
    Set(ByVal value As Integer)
      _NumberOfFlipsX = value
    End Set
  End Property

  Private _PartBackColor As Color
  Public Property PartBackColor() As Color
    Get
      Return _PartBackColor
    End Get
    Set(ByVal value As Color)
      _PartBackColor = value
    End Set
  End Property

  Private _BackColor As Color
  Public Property BGColor() As Color
    Get
      Return _BackColor
    End Get
    Set(ByVal value As Color)
      _BackColor = value
    End Set
  End Property

  Private _TextColor As Color
  Public Property TextColor() As Color
    Get
      Return _TextColor
    End Get
    Set(ByVal value As Color)
      _TextColor = value
    End Set
  End Property
  Private _OldText As String = ""

  Public Sub New()

    ' Dieser Aufruf ist für den Designer erforderlich.
    InitializeComponent()

    ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    Me.BackColor = BGColor

  End Sub
  'Private _Text As String
  'Public Property Text() As String
  '  Get
  '    Return _Text
  '  End Get
  '  Set(ByVal value As String)
  '    _Text = value
  '  End Set
  'End Property
  Private Sub FlipboardGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ColFlips = New List(Of FlipboardCTL)
    ControlMissing()

  End Sub
  Sub ControlMissing()
    Dim xF As FlipboardCTL
    Do Until NumberOfFlipsX >= ColFlips.Count
      xF = ColFlips.Item(ColFlips.Count - 1)
      Me.Controls.Remove(xF)
      ColFlips.Remove(xF)
    Loop

    Do Until NumberOfFlipsX <= ColFlips.Count
      xF = New FlipboardCTL()
      ColFlips.Add(xF)
      Me.Controls.Add(xF)
    Loop

    Dim xLine As Integer = 0
    For Each NF In ColFlips
      NF.Width = (Me.Width / ColFlips.Count) / 1.05
      NF.Left = xLine
      NF.Height = Me.Height
      NF.Top = 0
      NF.BGColor = PartBackColor
      NF.FontColor = TextColor
      xLine += NF.Width * 1.05
    Next

  End Sub
  Sub Settext()
    _OldText = Text.PadRight(ColFlips.Count, " ").Substring(0, ColFlips.Count)
    Text = _OldText

    Dim XPos As Integer = 0

    For Each NF In ColFlips
      NF.SollChar = Text.Substring(XPos, 1)
      XPos += 1
    Next


  End Sub

  Private Sub tmrValChanged_Tick(sender As Object, e As EventArgs) Handles tmrValChanged.Tick
    If _OldNuberOfFlipsX <> _NumberOfFlipsX Then ControlMissing()
    If _OldText <> Text Then Settext()

  End Sub
End Class
