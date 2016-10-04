Public Class CreationExample
  Private MyState as String = "DEFAULT"

  Public Property State As String
    Get
      Return MyState
    End Get

    Set(Value As String)
      MyState = Value
    End Set
  End Property
End Class

Module DefaultConstructor
  Sub Main()
    Dim C As New CreationExample()
    Console.WriteLine(C.State)
  End Sub
End Module
