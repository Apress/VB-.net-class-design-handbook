Imports System

Module MyTest
  Sub Main()
    Console.WriteLine("Please enter a value from " & _
      Counter.MIN_COUNT & " to " & Counter.MAX_COUNT)
    Try
      Dim input As Integer = Console.ReadLine()
      if input < Counter.MIN_COUNT or _
         Input > Counter.MAX_COUNT Then
        Console.WriteLine("Value is out of acceptable range!")
      Else
        Console.WriteLine("The value " & input.ToString() & _
                          " is acceptable!")
      End If
    Catch e As InvalidCastException
      Console.Write("The value you entered was not numeric!")    
    End Try
  End Sub
End Module

Public Class Counter
  Public Const MAX_COUNT As Integer = 500
  Public Const MIN_COUNT As Integer = 100
End Class
