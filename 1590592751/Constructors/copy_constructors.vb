Public Class Point
  Private MX as Integer
  Private MY as Integer

  Sub New(X As Integer, Y As Integer)
    MX = X
    MY = Y
  End Sub

  Sub New(ToCopy As Point)
    MX = ToCopy.X
    MY = ToCopy.Y
  End Sub

  Public ReadOnly Property X as Integer
    Get
      Return MX
    End Get
  End Property

  Public ReadOnly Property Y as Integer
    Get
      Return MY
    End Get
  End Property

  Public Overloads Function ToString() As String
    Return "(" & MX & "," & MY & ")"
  End Function
End Class

Module CopyConstructor
  Sub Main()
    Dim P1 as New Point(5, 5)
    Dim P2 as New Point(P1)

    Console.WriteLine("First Object: " & P1.ToString()) 
    Console.WriteLine("Cloned Object: " & P2.ToString())
  End Sub
End Module
