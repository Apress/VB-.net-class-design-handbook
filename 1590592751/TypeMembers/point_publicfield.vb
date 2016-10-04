Imports System
Module PointPublic
  Sub Main()
    Dim p as Point = New Point()
    Console.WriteLine("(" & p.X & "," & p.Y & ")") 
    p.X = -100
    p.Y = -100
    Console.WriteLine("(" & p.X & "," & p.Y & ")") 
  End Sub
End Module

Public Class Point
  Public Y as Integer	'Public Field
  Public X as Integer	'Public Field
End Class
