Imports System
Module Test
  Sub Main()
    Dim f as New ObjectFriend("Visual Basic", 1)
    Dim f2 as New ObjectFriend("Visual Basic", 1)
    Console.WriteLine(f2.Equals(f))   'True!  
    f = f2
    Console.WriteLine(f2.Equals(f))

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

  Public Overrides Overloads Function Equals(Obj as Object) as Boolean
    'Value equality test
    If Not IsNothing(Obj)
      If TypeOf Obj is ObjectFriend then
        If CType(Obj, ObjectFriend).Name = Me.Name and CType(Obj, ObjectFriend).Value = Me.Value then 
          Return True
        End If
      End If
    End If
    Return False
  End Function

End Class
