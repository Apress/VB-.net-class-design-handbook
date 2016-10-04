Imports System
Module Test
  Sub Main()
    Dim p1 as New Point()
    Dim p2 as New Point(100,100) 
    Console.WriteLine(p1)
    Console.WriteLine(p2)
  End Sub
End Module

Class Point
  Private xVal as Integer
  Private yVal as Integer

  Sub New()
  End Sub

  Sub New(x as integer, y as Integer)
    Me.xVal = x
    Me.yVal = y
  End Sub

  Public Property X as Integer
    Get 
      Return(me.xVal)
    End Get
    Set
      Me.xVal = value
    End Set
  End Property

  Public Property Y
    Get
      Return(me.yVal)
    End Get
    set
      Me.yVal = value
    End Set
  End Property

  Public Overrides Function ToString() as String
    Return("(" & X & "," & Y & ")")  
  End function
End Class
