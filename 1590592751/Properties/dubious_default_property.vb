Imports System
Imports System.Collections

Class Employer
  Private mEmployees As Hashtable

  Private mOffices As Hashtable

  Public Sub New()
    mEmployees = New Hashtable()
    mOffices = New Hashtable()
  End Sub

  Public Default Property Employee(ByVal ID As Integer) As Person
    Get
      Dim theObject As Object
      theObject = mEmployees(ID)
      Return CType(theObject, Person)
    End Get

    Set(ByVal Value As Person)
      mEmployees(ID) = Value
    End Set
  End Property

  Public Property Office(ByVal country As String) As String
    Get
      Dim theObject As Object
      theObject = mOffices(country)
      Return CType(theObject, String)
    End Get

    Set(ByVal Value As String)
      mOffices(country) = Value
    End Set
  End Property
End Class


Class Person
  Private mName As String
  Private mWage As Double
  Private mID As Integer

  Public Sub New(ByVal name As String, _
                 ByVal wage As Double, _
                 ByVal id As Integer)
    mName = name
    mWage = wage
    mID = id
  End Sub

  Public Property Name() As String
    Get
      Return mName
    End Get

    Set(ByVal Value As String)
      mName = Value
    End Set
  End Property

  Public ReadOnly Property Wage() As Double
    Get
      Return mWage
    End Get
  End Property

  Public ReadOnly Property ID() As Integer
    Get
      Return mID
    End Get
  End Property

  Public Sub PayRise(ByVal amount As Double)
    mWage += amount
  End Sub

  Public Overrides Function ToString() As String
    Return "[" & mID & "] " & mName & " " & mWage
  End Function
End Class
Module DefaultProperty
  Sub Main()
    Dim employer As New Employer()

    employer(1) = New Person("Andy", 25000, 1)
    employer(2) = New Person("Jayne", 35000, 2)
    employer(3) = New Person ("Thomas", 17000, 3)
    employer(4) = New Person("Emily", 16500, 4)

    employer.Office("USA") = "Aspen"
    employer.Office("Canada") = "Whistler"
    employer.Office("France") = "Val d'Isère"
    employer.Office("Austria") = "Zell am See"
    employer.Office("Switzerland") = "Zermatt"
    employer.Office("Italy") = "Livigno"

    Console.Write("Enter a country to ski in: ")
    Dim country As String
    country = Console.ReadLine()

    Dim city As String
    city = employer.Office(country)

    If city Is Nothing Then
      Console.WriteLine("No office in {0}", country)
    Else
      Console.WriteLine("Office in {0}: {1}", country, city)
    End If
  End Sub
End Module