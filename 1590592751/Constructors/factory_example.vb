Module FactoryExample
  Sub Main()
    Dim SF As New SodaFactory()
    Dim Pop As ISoda
    Dim AnotherPop As ISoda

    Pop = SF.GetSoda("MountainDew")
    AnotherPop = SF.GetSoda("Coke")
    Pop.Drink(10)
    AnotherPop.Drink(10)

    Console.WriteLine(Pop.Name & " has " & _
      Pop.Remaining & " gulps left.")
    Console.WriteLine(AnotherPop.Name & " has " & _
      AnotherPop.Remaining & " gulps left")
  End Sub
End Module

Public Class SodaFactory
  Public Function GetSoda(Name As String) As ISoda
    If Name.ToUpper() = "MOUNTAINDEW" Then
      Return New MountainDew("DEW")
    Elseif Name.ToUpper() = "COKE" Then
      Return New Coke("COKE")
    Else
      Throw New ArgumentOutOfRangeException("Name", _
        "We do not carry " & Name)
    End If
  End Function
End Class

Public Interface ISoda
  ReadOnly Property Name as String 
  ReadOnly Property Remaining As Integer 
  Sub Drink(Gulps as Integer)
End Interface
 
Public Class MountainDew
  Implements ISoda

  Private MName as String
  Private MRemaining as Integer = 100

  Public Sub New(Name As String) 
    MName = Name
  End Sub

  Public ReadOnly Property Name As String Implements ISoda.Name
    Get
      Return MName
    End Get
  End Property

  Public ReadOnly Property Remaining As Integer _
                           Implements ISoda.Remaining
    Get
      Return MRemaining
    End Get
  End Property

  Sub Drink(Gulps as Integer) Implements ISoda.Drink
    If Gulps < 0 Then 
      Throw New ArgumentOutOfRangeException("Gulps", _
        "Cannot drink negative gulps")
    ElseIf Gulps * 2 > MRemaining Then
      MRemaining = 0
    Else
      MRemaining -= Gulps * 2
    End If
  End Sub
End Class

Public Class Coke
  Implements ISoda

  Private MName As String
  Private MRemaining As Integer = 100

  Public Sub New(Name As String)
    MName = Name
  End Sub

  Public ReadOnly Property Name As String Implements ISoda.Name
    Get
      Return MName
    End Get
  End Property

  Public ReadOnly Property Remaining As Integer _
                  Implements ISoda.Remaining
    Get
      Return MRemaining
    End Get
  End Property

  Sub Drink(Gulps As Integer) Implements ISoda.Drink
    If Gulps < 0 Then 
      Throw New ArgumentOutOfRangeException("Gulps", _
        "Cannot drink negative gulps")
    ElseIf Gulps > MRemaining then
      MRemaining = 0
    Else
      MRemaining -= Gulps
    End If
  End Sub
End Class 
