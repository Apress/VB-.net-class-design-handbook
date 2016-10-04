Imports System

Module FieldInit
  Sub Main()
    Dim ProgrammerInstance As Programmer
    ProgramerInstance = New Programmer()
    Console.WriteLine("Name is: " & ProgrammerInstance.Name)
    Console.WriteLine("Address is: " & ProgrammerInstance.Address)
    Console.WriteLine("ID is: " & ProgrammerInstance.ID)
  End Sub
End Module

Public Class Programmer
  Public Name As String = "New Programmer"
  Public Address As String
  Public ID As Integer
End Class
