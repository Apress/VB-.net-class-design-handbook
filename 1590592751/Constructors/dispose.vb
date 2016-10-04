Class Point
  Implements IDisposable
 
  Private MX = 3
  Private MY = 4

  Sub New(X As Integer, Y As Integer)
    MX = X
    MY = Y
  End Sub 

  Public Property X As Integer
    Get
      Return MX
    End Get

    Set(Value As Integer)
       MX = Value
    End Set
  End Property

  Public Property Y As Integer
    Get
      Return MY
    End Get

    Set(Value As Integer)
      MY = Value
    End Set
  End Property

  Public Overrides Function ToString() As String
    Return "(" & MX & "," & MY & ")"
  End Function

  Public Overridable Overloads Sub Dispose() _
         Implements IDisposable.Dispose
    Console.WriteLine("Point " & Me.ToString() & " disposed of")
  End Sub 
End Class

Class PointPair
  Implements IDisposable

  Public First As Point
  Public Second As Point

  Public Sub New()
    First = New Point(1, 2)
    Second = New Point(3,4)
  End Sub

  Public Overrides Function ToString() As String
    Return "(" & First.ToString() & "," & Second.ToString() & ")"
  End Function

  Public Overridable Overloads Sub Dispose() _
                     Implements IDisposable.Dispose
    First.Dispose()
    Second.Dispose()
    First = Nothing
    Second = Nothing
  End Sub

  Protected Overridable Overloads Sub Finalize()
    First.Dispose() 
    Second.Dispose()
    First = Nothing
    Second = Nothing
  End Sub 
End Class

Module DisposePoint
  Sub Main()
    Dim P As PointPair = New PointPair()
    Console.WriteLine("The object is: " & P.ToString())
    P.Dispose()
    P = Nothing
    Console.WriteLine("The object, after disposal is " & _
      P.ToString())
  End Sub
End Module