Public Class Point
  Implements ICloneable

  Private MX as Integer
  Private MY as Integer

  Sub New(X as Integer, Y as Integer)
    MX = X
    MY = Y
  End Sub

  Public Property X as Integer
    Get
      Return MX
    End Get

    Set(Value As Integer)
      MX = Value
    End Set
  End Property

  Public Property Y as Integer
    Get
      Return MY
    End Get

    Set(Value As Integer)
      MY = Value
    End Set
  End Property

  Public Overloads Function ToString() As String
    Return "(" & MX & "," & MY & ")"
  End Function

  Public Overridable Function Clone() As Object _
                     Implements ICloneable.Clone
    Return New Point(MX, MY)
  End Function
End Class

Public Class Line 
  Inherits Point

  Private MPoint As Point

  Sub New(X As Integer, Y As Integer, Other As Point)
    MyBase.New(X, Y)
    MPoint = Other.Clone()
  End Sub

  Public Property Other As Point
    Get
      Return MPoint
    End Get

    Set(Value As Point)
      MPoint = Value
    End Set
  End Property

  Public Overloads Function ToString() As String
    Return "(" & Me.X & "," & Me.Y & ")"  & _
      " Other: " & MPoint.ToString()
  End Function

  Public Overrides Function Clone() As Object
    Return New Line(Me.X, Me.Y, MPoint.Clone())
  End Function
End Class

Module ICloneableConstructor 
  Sub Main()
    Dim P as New Point(4, 5)
    Dim P1 As New Line(3,4, P)
    Dim P2 As Line
    P2 = P1.Clone()
    Console.WriteLine("Object Cloned, now changing the Other " & _
      "property on clone")
    P2.Other.X = 5
    P2.Other.Y = 4
    Console.WriteLine("First Object: " & P1.ToString()) 
    Console.WriteLine("Cloned Object: " & P2.ToString())
  End Sub
End Module
