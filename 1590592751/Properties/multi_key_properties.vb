Imports System
Imports System.Collections

Structure PersonKey
  Private MLocation As String
  Private MID As Integer

  Public Sub New(ByVal Location As String, ByVal ID As Integer)
    MLocation = Location
    MID = ID
  End Sub

  Public ReadOnly Property Location() As String
    Get
      Return MLocation
    End Get
  End Property

  Public ReadOnly Property ID() As Integer
    Get
      Return MID
    End Get
  End Property

  Public Overrides Function GetHashCode() As Integer
    Return Location.GetHashCode() + ID
  End Function

  Public Overloads Overrides Function Equals(ByVal Obj As Object) _
                                            As Boolean
    If (Obj Is Nothing) Or Not (Me.GetType() Is Obj.GetType()) Then
      Return False
    Else
      Dim Other As PersonKey = CType(Obj, PersonKey)
      If Me.Location = Other.Location And Me.ID = Other.ID Then
        Return True
      Else
        Return False
      End If
    End If
  End Function
End Structure

Class Person
  Private MName As String
  Private MWage As Double

  Public Sub New(ByVal Name As String, ByVal Wage As Double)
    MName = Name
    MWage = Wage
  End Sub

  Public Property Name() As String
    Get
      Return MName
    End Get

    Set(ByVal Value As String)
      MName = Value
    End Set
  End Property

  Public ReadOnly Property Wage() As Double
    Get
      Return MWage
    End Get
  End Property

  Public Sub PayRaise(ByVal Amount As Double)
    MWage += Amount
  End Sub

  Public Overrides Function ToString() As String
    Return MName & " " & MWage
  End Function
End Class

Class Employer
  Private MEmployees As Hashtable

  Public Sub New()
    MEmployees = New Hashtable()
  End Sub

  Public Property Employee(ByVal Location As String, _
                           ByVal ID As Integer) As Person
    Get
      Dim Key As New PersonKey(Location, ID)
      Return MEmployees(Key)
    End Get

    Set(ByVal Value As Person)
      Dim Key As New PersonKey(Location, ID)
      MEmployees(Key) = Value
    End Set
  End Property
End Class

Module MultiKeyProperties
  Sub Main()
    Dim Employer As New Employer()

    Employer.Employee("London", 100) = New Person("Andy", 25000)
    Employer.Employee("London", 200) = New Person("Jayne", 35000)
    Employer.Employee("Boston", 200) = New Person("Thomas", 17000)
    Employer.Employee("Geneva", 200) = New Person("Emily", 16500)

    Dim Who As Person
    Who = Employer.Employee("Boston", 200)
    Console.WriteLine("{0}", Who)

    Who = Employer.Employee("Geneva", 200)
    Console.WriteLine("{0}", Who)
  End Sub
End Module
