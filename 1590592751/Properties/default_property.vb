Imports System
Imports System.Collections

Class Employer
  Private mEmployees As Hashtable

  Public Sub New()
    mEmployees = New Hashtable()
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

    employer.Employee(1) = _
      New Person("Andy", 25000, 1)
    employer.Employee(2) = _
      New Person("Jayne", 35000, 2)
    employer.Employee(3) = _
      New Person("Thomas", 17000, 3)
    employer.Employee(4) = _
      New Person("Emily", 16500, 4)

    Console.Write("Enter an ID: ")
    Dim ID As Integer
    ID = Integer.Parse(Console.ReadLine())

    Dim who As Person
    who = employer.Employee(ID)

    If who Is Nothing Then
      Console.WriteLine("Unrecognized ID: {0}", ID)
    Else
      Console.WriteLine("Person details: {0}", who)
    End If
  End Sub
End Module