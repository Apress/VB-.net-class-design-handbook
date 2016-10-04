' primitive_types.vb
Imports System                ' For Console class
Imports Microsoft.VisualBasic ' For vbCrLf

Module MyModule

  Sub Main()

    ' Use a primitive Visual Basic .NET type
    Dim i As Integer = 100

    ' Use the equivalent .NET Framework type
    Dim j As Int32 = i

    Console.WriteLine("Integer: {0}", GetType(Integer).FullName)
    Console.WriteLine("Int32:   {0}", GetType(Int32).FullName)

    ' Ask user for numerator and denominator
    Console.Write(vbCrLf & "Enter a double: ")
    
    Dim input As String = Console.ReadLine()
        Dim num As Double = Double.Parse(input)

    Console.Write("Enter another double: ")
    input = Console.ReadLine()
        Dim denom As Double = Double.Parse(input)

    ' Calculate quotient and display it
    Dim res As Double = num / denom

    If (Double.IsNaN(res)) Then
      Console.WriteLine("Not a Number.")
    ElseIf (Double.IsPositiveInfinity(res)) Then
      Console.WriteLine("Positive infinity.")
    ElseIf (Double.IsNegativeInfinity(res)) Then
            Console.WriteLine("Negative infinity.")
    Else
      Console.WriteLine("Result is {0}.", res)
    End If
  End Sub
End Module
