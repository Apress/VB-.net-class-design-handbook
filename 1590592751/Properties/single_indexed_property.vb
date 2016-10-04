Imports System
Imports System.Collections

Class Person
  Private MName As String
  Private MWage As Double

  Public Sub New(ByVal Name As String, _
                 ByVal Wage As Double)
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

  Public Property Employee(ByVal ID As Integer) As Person
    Get
      Dim TheObject As Object
      TheObject = MEmployees.Item(ID)
      Return CType(TheObject, Person)
    End Get

    Set(ByVal Value As Person)
      MEmployees.Item(ID) = Value
    End Set
  End Property
End Class

Module SingleIndexedProperty
  Sub Main()
    Dim Employer As New Employer()

    Employer.Employee(1) = New Person("Andy", 25000)
    Employer.Employee(2) = New Person("Jayne", 35000)
    Employer.Employee(3) = New Person("Thomas", 17000)
    Employer.Employee(4) = New Person("Emily", 16500)

    Console.Write("Enter an ID: ")
    Dim ID As Integer
    ID = Integer.Parse(Console.ReadLine())

    Dim Who As Person
    Who = employer.Employee(ID)

    If Who Is Nothing Then
      Console.WriteLine("Unrecognized ID: {0}", ID)
    Else
      Console.WriteLine("Person details: {0}", Who)
    End If
  End Sub
End Module
