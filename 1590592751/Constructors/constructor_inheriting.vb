Public Class Location
  Private MyState as String = "DEFAULT"

  Sub New()
    MyBase.New()
    Console.WriteLine("Location Created")
  End Sub

  Public Property State As String
    Get
      Return MyState
    End Get

    Set(Value As String)
      MyState = Value
    End Set
  End Property
End Class

Public Class SpecificLocation
  Inherits Location

  Private MyAddress as String

  Sub New()
    MyBase.New()
    Console.WriteLine("SpecificLocation Created")
  End Sub

  Public Property Address as String
    Get
      Return MyAddress
    End Get

    Set(Value As String)
      MyAddress = Value
    End Set
  End Property
End Class

Module ConstructorCalling
  Sub Main()
    Dim SL As New SpecificLocation() 
    SL.State = "CANADA"
    SL.Address = "123 Winnipeg Way"
  End Sub
End Module
