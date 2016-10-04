Namespace PointClass
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
End Namespace 
