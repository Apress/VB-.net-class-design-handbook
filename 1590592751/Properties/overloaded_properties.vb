Imports System
Imports System.Collections

Class Person
  Private MName As String
  Private MWage As Double
  Private MID As Integer

  Public Sub New(ByVal Name As String, ByVal Wage As Double, _
                 ByVal ID As Integer)
        MName = Name
        MWage = Wage
        MID = ID
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

  Public ReadOnly Property ID() As Integer
    Get 
      Return MID
    End Get
  End Property

  Public Overrides Function ToString() As String
    Return "[" & MID & "]" & " " & MName & " " & MWage
  End Function
End Class

Class Employer
  Private MEmployees As ArrayList

  Public Sub New()
    MEmployees = New ArrayList()
  End Sub

  Public Property Employee(ByVal ID As Integer) As Person
    Get
      Dim CountValue As Integer
      Dim ReturnValue as Person = Nothing
      For CountValue = 0 To MEmployees.Count - 1
        Dim PersonInstance As Person
        PersonInstance = CType(MEmployees(CountValue), Person)
        If PersonInstance.ID = ID Then
          ReturnValue = PersonInstance
          Exit For
        End If
      Next
      Return ReturnValue
    End Get

    Set(ByVal Value As Person)
      Dim CountValue As Integer
      For CountValue = 0 To MEmployees.Count - 1
        Dim PersonInstance As Person
        PersonInstance = CType(MEmployees(CountValue), Person)
        If PersonInstance.ID = ID Then
          MEmployees(CountValue) = Value
          Return
        End If
      Next
      MEmployees.Add(Value)
    End Set
  End Property

  Public Property Employee(ByVal Name As String) As Person
    Get
      Dim CountValue As Integer
      Dim ReturnValue As Person = Nothing
      For CountValue = 0 To MEmployees.Count - 1
        Dim PersonInstance As Person
        PersonInstance = CType(MEmployees(CountValue), Person)
        If PersonInstance.Name = Name Then
          ReturnValue=PersonInstance
          Exit For
        End If
      Next
      Return ReturnValue
    End Get

    Set(ByVal Value As Person)
      Dim CountValue As Integer
      For CountValue = 0 To MEmployees.Count - 1
        Dim PersonInstance As Person
        PersonInstance = CType(MEmployees(CountValue), Person)
        If PersonInstance.Name = Name Then
          MEmployees(CountValue) = Value
          Return
        End If
      Next
      MEmployees.Add(Value)
    End Set
  End Property
End Class

Module OverloadedProperties
  Sub Main()
    Dim Employer As New Employer()

    Employer.Employee(100) = New Person("Andy", 25000, 100)
    Employer.Employee(200) = New Person("Jayne", 35000, 200)
    Employer.Employee(300) = New Person("Thomas", 17000, 300)
    Employer.Employee(400) = New Person("Emily", 16500, 400)

    Employer.Employee("Nigel") = New Person("Nigel", 50000, 500)
    Employer.Employee("Claire") = New Person("Claire", 60000, 600)

    Console.Write("Enter an ID: ")
    Dim ID As Integer
    ID = Integer.Parse(Console.ReadLine())

    Dim Who As Person
    Who = Employer.Employee(ID)

    If Who Is Nothing Then
      Console.WriteLine("Unrecognized ID: {0}", ID)
    Else
      Console.WriteLine("Person details: {0}", Who)
    End If

    Console.Write(Microsoft.VisualBasic.Constants.vbCrLf & _
      "Enter a name: ")
    Dim Name As String
    Name = Console.ReadLine()

    Who = Employer.Employee(Name)

    If Who Is Nothing Then
      Console.WriteLine("Unrecognized name: {0}", Name)
    Else
      Console.WriteLine("Person details: {0}", Who)
    End If
  End Sub
End Module
