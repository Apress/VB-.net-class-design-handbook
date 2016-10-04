Imports System
Public Module ArgumentOrder

Public Function Add(ByVal Num1 As Integer, ByVal Num2 As Double) _
                                                      As Double
    Return Num1 + Num2
End Function

Public Function Add(ByVal Num2 As Double, ByVal Num1 As Integer) _
                                                      As Double
    Return Num1 - Num2
End Function

Sub Main()

    Dim Num3 As Double = Add(2, 4.2)
    Dim Num4 As Double = Add(4.2 , 2)

    Console.WriteLine("The first Add Method " & Num3)
    Console.WriteLine("The Second Add Method " & Num4)

End Sub
End Module 
