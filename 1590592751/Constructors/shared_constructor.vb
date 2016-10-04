Public Class Employee
  Private Shared EmpID as Integer = 10

  Public Shared ReadOnly Property CurrentID as Integer
    Get
      Return EmpID
    End Get
  End Property

  Public Shared Function GetEmployeeID() as Integer
    EmpID += 1
    Return EmpID
  End Function

  Shared Sub New()
    Console.WriteLine("Before init: " & EmpID)
    EmpID = 100
    Console.WriteLine("After init: " & EmpID)
  End Sub
End Class

Module SharedConstructor
  Sub Main()
    Dim CountValue As Integer
    For CountValue = 1 to 10
      Console.WriteLine(Employee.GetEmployeeID())
    Next
  End Sub
End Module
