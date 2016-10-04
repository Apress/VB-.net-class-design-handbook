Imports System

Module ConstructorIntro
  Sub Main()
    Dim c1 As New CreationExample()
    Dim c2 As New CreationExample("Hello World")
    Dim c3 As New CreationExample("Hello", "World")
    Console.WriteLine(c1.State)
    Console.WriteLine(c2.State)
    Console.WriteLine(c3.State)
  End Sub
End Module

Public Class CreationExample
  Private MyState As String

  Sub New()
    Console.WriteLine("New() fired")
    MyState = "DEFAULT"
  End Sub

  Sub New(Value as String)
    Console.WriteLine("New(String) fired")
    MyState = Value
  End Sub

  Sub New(Value as String, Value2 as String)
    Console.WriteLine("New(String, String) fired")
    MyState = Value & " " & Value2
  End Sub

  Public ReadOnly Property State As String
    Get
      Return MyState
    End Get
  End Property
End Class
