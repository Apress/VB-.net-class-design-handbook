Imports System
Imports Microsoft.VisualBasic
Module PassingArrays

  Dim counter As Integer

  Public Sub AddOne(ByVal InputArray() As Integer)
    For counter = 0 To UBound(InputArray)
      InputArray(counter) = InputArray(counter) + 1
    Next
  End Sub

  Sub Main()
    Dim listOfNumbers() As Integer = {2, 4, 6, 8}
    For counter = 0 To UBound(listOfNumbers)
      Console.WriteLine("{0}", listOfNumbers(counter))
    Next
    Console.WriteLine()
    AddOne(listOfNumbers)
    For counter = 0 To UBound(listOfNumbers)
      Console.WriteLine("{0}", listOfNumbers(counter))
    Next
    Console.ReadLine()
  End Sub
End Module
