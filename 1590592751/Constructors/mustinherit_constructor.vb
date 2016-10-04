Public MustInherit Class Stock
  Private MPrice As Single
  Private MLocation As String = "Unshelved"
  Private MDummy As Boolean = False
  Private MType As String = "Not Defined"

  Public ReadOnly Property Dummy As Boolean
    Get
      Return MDummy
    End Get
  End Property

  Public Property Price As Single
    Get
      Return MPrice
    End Get

    Set(Value As Single)
      If Value > 0 Then MPrice = Value
    End Set
  End Property

  Public Property Location As String
    Get
      Return MLocation
    End Get

    Set(Value As String)
      MLocation = Value
    End Set
  End Property
 
  Public ReadOnly Property Type As String
    Get
      Return MType
    End Get
  End Property 

  Protected Sub New(Type As String, _
                    Optional Dummy As Boolean = False)
    If Dummy Then MDummy = True 
    MType = Type
  End Sub 
End Class

Class CDType
  Inherits Stock

  Private MTitle = "Test Title"

  Public Sub New()
    MyBase.New("CD")
  End Sub

  Public Sub New(Dummy As Boolean)
    MyBase.New("CD", Dummy)
  End Sub

  Public Sub New(Title As String, Optional Dummy As Boolean = False)
    Me.New(Dummy)
    MTitle = Title
  End Sub

  Public ReadOnly Property Title As String
    Get
      Return MTitle
    End Get
  End Property
End Class

Module CreateCDs
  Sub Main()
    Dim C1 = New CDType("Show of Hands - Live")
    Dim C2 = New CDType("Hourglass", True)

    C1.Price = 9.99
    C2.Price = 12.99

    Console.WriteLine("Please Enter the shelving location of " & _
      C1.Title & ":"
    C1.Location = Console.ReadLine()
    Console.WriteLine("Please Enter the shelving location of " & _
      C2.Title & ":"
    C2.Location = Console.ReadLine()

    Console.WriteLine(C1.Title & " is shelved at " & C1.Location & _
      " and costs " & C1.Price & ".")
    Console.WriteLine(C2.Title & " is shelved at " & C2.Location & _
      " and costs " & C2.Price & ".")
  End Sub
End Module
