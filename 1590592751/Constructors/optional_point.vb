Public Class Point
  Private MX as Integer
  Private MY as Integer

  Public Sub New(Optional X As Integer = 0, _
                 Optional Y As Integer = 0)
    MX = X
    MY = Y
  End Sub

  Public Overrides Function ToString() As String 
    Return "(" & MX & "," & MY & ")"
  End Function
End Class

Module OptionalPoint
  Sub Main
    Dim P1 As New Point()
    Console.WriteLine(P1.ToString())

    Dim P2 As New Point(1, 1)
    Console.WriteLine(P2.ToString())

    Dim P3 As New Point(, 1)
    Console.WriteLine(P3.ToString())

    Dim P4 As New Point(9, )
    Console.WriteLine(P4.ToString())
  End Sub
End Module
