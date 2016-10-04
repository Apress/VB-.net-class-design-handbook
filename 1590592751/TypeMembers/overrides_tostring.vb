Imports System

Module Test
  Sub Main()
    Dim f as New ObjectFriend("Visual Basic", 1)
    Dim f2 as New ObjectFriend("Visual C#", 2)
    Console.WriteLine(f)
    Console.WriteLine(f2)
  End Sub
End Module

Public Class ObjectFriend
  Private Name as String
  Private Value as Integer

  Public Sub New(Name as String, Value as Integer)
    Me.Name = Name
    Me.Value = Value
  End Sub
  Public Overrides Function ToString() as String
    Return(Name & " has the value " & Value)
  End Function
End Class
