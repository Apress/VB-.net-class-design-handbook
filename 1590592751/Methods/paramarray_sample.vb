Imports System

Module ParamArraySample
  Public Class Maths
    Public Function AddSomeNumbers(ByVal ParamArray NumberList() _
      As Integer) As Integer
      Dim Count As Integer = 0
      Dim LoopValue As Integer

      For LoopValue = 0 To (NumberList.Length - 1)
        Count = Count + NumberList(LoopValue)
      Next

      Return Count
    End Function
  End Class

  Sub Main()
    Dim Numbers() As Integer = {1970, 1971, 2000, 2002, 1887, 1986}
    Dim Maths As New Maths()

    Console.WriteLine("The total is - {0}", _
      Maths.AddSomeNumbers(27, 8, 9, 1))

    Console.WriteLine("The total is - {0}", _
      Maths.AddSomeNumbers(Numbers))
  End Sub
End Module
