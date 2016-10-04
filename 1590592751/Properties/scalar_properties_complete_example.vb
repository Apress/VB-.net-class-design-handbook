Imports System
Imports System.Drawing
Imports System.IO 

Class FootballTeam
  Private MName As String 
  Private MJerseyColor As Color
  Private MWins, MDraws, MDefeats As Short
  Private MLogging As Boolean

  Public Sub New(ByVal Name As String, ByVal Jersey As Color)
    MName = Name
    MJerseyColor = Jersey
  End Sub

  Public ReadOnly Property Name() As String
    Get
      Return MName
    End Get
  End Property

  Public ReadOnly Property Points() As Short
    Get
      Return (MWins * 3) + (MDraws * 1)
    End Get
  End Property

  Public Property JerseyColor() As Color
    Get
      Return MJerseyColor
    End Get

    Set(ByVal Value As Color)
      If Value.Equals(Color.Black) Then
        Throw New ArgumentException("Cannot have black jerseys")
      End If
      MJerseyColor = Value
    End Set
  End Property

  Public WriteOnly Property Logging() As Boolean
    Set(ByVal Value As Boolean)
      MLogging = Value
    End Set
  End Property

  Private ReadOnly Property LogStream()As FileStream
    Get
      Try
        Return New FileStream( _
          MName & ".log", FileMode.Append, FileAccess.Write)
      Catch Ex As Exception
        Return New FileStream("Default.log", FileMode.Append, _
          FileAccess.Write)
      End Try
    End Get
  End Property

  Public Sub PlayGame(ByVal Opponent As String, _
                      ByVal GoalsFor As Short, _
                      ByVal GoalsAgainst As Short)
    If GoalsFor > GoalsAgainst Then
      MWins += 1
    ElseIf GoalsFor = GoalsAgainst Then
      MDraws += 1
    Else
      MDefeats += 1
    End If

    If MLogging Then
      Dim Writer As New StreamWriter(LogStream)
      Writer.WriteLine("{0} {1}-{2} {3}", _
        MName, GoalsFor, GoalsAgainst, Opponent)
      Writer.Flush()
      Writer.Close()
    End If
  End Sub
End Class

Module ScalarProperties
  Sub Main()
    Dim MyTeam As New FootballTeam( _
      "Swansea", Color.White)

    Console.WriteLine("Team: {0}", MyTeam.Name)
  
    MyTeam.JerseyColor = Color.Yellow
    Console.WriteLine("Jerseys: {0}", MyTeam.JerseyColor)

    MyTeam.Logging = True

    MyTeam.PlayGame("Liverpool", 1, 1)
    MyTeam.PlayGame("Chelsea", 3, 1)
    MyTeam.PlayGame("Manchester United", 0, 4)
    MyTeam.PlayGame("Everton", 2, 0)

    Console.WriteLine("Points: {0} ", MyTeam.Points)
    Console.ReadLine
  End Sub
End Module
