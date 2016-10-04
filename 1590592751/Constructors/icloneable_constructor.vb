Public Class Point
  Implements ICloneable

  Private MX as Integer
  Private MY as Integer

  Sub New(X as Integer, Y as Integer)
    MX = X
    MY = Y
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

  Public Overridable Function Clone() As Object _
                     Implements ICloneable.Clone
    Return New Point(MX, MY)
  End Function
End Class

Module ICloneableConstructor
  Sub Main()
    Dim P1 As New Point(5, 5)
    Dim P2 As Point

    P2 = P1.Clone()
    Console.WriteLine("First Object: " & P1.ToString()) 
    Console.WriteLine("Cloned Object: " & P2.ToString())
  End Sub
End Module
