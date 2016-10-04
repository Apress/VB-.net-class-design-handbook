Imports System

Module PointProperties
  Sub Main()
    Dim p as Point = New Point()
    Console.WriteLine("(" & p.X & "," & p.Y & ")") 
    Try
      p.X = -100
      p.Y = -100
    Catch e as ArgumentOutOfRangeException
      Console.WriteLine(e.Message)
    End Try
    Console.WriteLine("(" & p.X & "," & p.Y & ")") 
  End Sub
End Module

Public Class Point
  Private yCoord as Integer
  Private xCoord as Integer
Public Property X as Integer
  Get
    Return(xCoord * 2) 
  End Get
  Set(ByVal Value as Integer)
    if Value < 0 then
      Throw New ArgumentOutOfRangeException("Value", 
        "X Coordinate must be greater than 0")
    End If
    xCoord = Value
  End Set
End Property
  
  Public Property Y as Integer
    Get
      Return(yCoord)
    End Get
    Set(ByVal Value as Integer)
      If Value < 0 then 
        Throw new ArgumentOutOfRangeException("Value", _
          "Y Coordinate must be greater than 0")
      End If
      yCoord = Value
    End Set
  End Property
End Class
