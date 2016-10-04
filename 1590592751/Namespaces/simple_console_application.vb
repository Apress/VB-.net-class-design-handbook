Imports System
Imports System.DateTime

Class Person
  Private MName As String
  Private MDOB As Date
 
  Sub New(Name As String, DOB As Date)
    MName = Name
    MDOB = DOB
  End Sub

  Private Sub New()
  End Sub 

  Public ReadOnly Property Age As Integer
    Get
      Dim ReturnValue As Integer = 0
      ReturnValue=Now.Year-MDOB.Year
      If Now.Month < MDOB.Month Or _
        (Now.Month = MDOB.Month And Now.Day < MDOB.Day) Then _
        ReturnValue -= 1
      Return ReturnValue
    End Get
  End Property

  Public Property Name As String
    Get
      Return MName
    End Get

    Set(Value As String)
      MName = Value
    End Set
  End Property 

  Public Overrides Overloads Function ToString() As String
    Return "Name: " & Me.Name & " - Age: " & Me.Age
  End Function
 
  Public Shared Sub Main()
    Dim Employee As Person = New Person("Andrew", "07/07/1975")
    Console.WriteLine(Employee.ToString())
  End Sub
End Class
