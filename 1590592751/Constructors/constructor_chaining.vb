Public Class SpecificLocation
  Private MAddress as String = "Default"
  Private MCity As String = "Default"

  Sub New()
    MyBase.New()
    Console.WriteLine("SpecificLocation Created")
  End Sub

  Sub New(Address as String, City As String)
    Me.New()

    MAddress = Address
    MCity = City
    Console.WriteLine("SpecificLocation.Address and Set")
  End Sub

  Public Property Address as String
    Get
      Return MAddress
    End Get

    Set(Value As String)
      MAddress = Value
    End Set
  End Property

  Public Property City as String
    Get
      Return City
    End Get
 
   Set(Value As String
      MCity = Value
    End Set
  End Property
End Class

Module ConstructorChain
  Sub Main()
    Dim SL As New SpecificLocation("123 First Street", "Somewhere")  
  End Sub
End Module
