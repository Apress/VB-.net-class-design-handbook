Imports System
Imports Microsoft.VisualBasic
Module PassingArrays

  Dim counter As Integer

  Public Sub AddOne(ByVal InputArray() As Integer)
    For counter = 0 To UBound(InputArray)
      InputArray(counter) = InputArray(counter) + 1
    Next
  End Sub
  Public Sub AddTwo(ByVal InputArray() As Integer)

    Dim tempArray() As Integer
    tempArray = InputArray.Clone
    For counter = 0 To UBound(tempArray)
      tempArray(counter) = tempArray(counter) + 2
    Next
  End Sub
  
    Sub Main()
        Dim listOfNumbers() As Integer = {6, 8, 7, 6}
        Dim theObject As Class1 = New Class1()

        For counter = 0 To UBound(listOfNumbers)
            Console.WriteLine("{0}", listOfNumbers(counter))
        Next

        Console.WriteLine()
        theObject.AddOne(listOfNumbers)

        For counter = 0 To UBound(listOfNumbers)
            Console.WriteLine("{0}", listOfNumbers(counter))
        Next

        Console.WriteLine()
        theObject.AddTwo(listOfNumbers)
        For counter = 0 To UBound(listOfNumbers)
            Console.WriteLine("{0}", listOfNumbers(counter))
        Next

        Console.ReadLine()
    End Sub

End Module
