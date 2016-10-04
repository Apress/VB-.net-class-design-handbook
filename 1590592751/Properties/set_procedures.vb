Imports System

Class MyColor
  Private MRed, MGreen, MBlue As Short

  Private Const Min As Short = 0
  Private Const Max As Short = 255
  Private Const Def As Short = 128

  Public Property Red() As Short
    Get
      Return mRed
    End Get

    Set(ByVal Value As Short)
      If Value >= Min And Value <= Max Then
        MRed = Value
      End If
    End Set
  End Property

  Public Property Green() As Short
    Get
      Return MGreen
    End Get

    Set(ByVal Value As Short)
      If Value >= Min And Value <= Max Then
        MGreen = Value
      Else
        MGreen = Def
      End If
    End Set
  End Property

  Public Property Blue() As Short
    Get
      Return MBlue
    End Get

    Set(ByVal Value As Short)
      If Value >= Min And Value <= Max Then
        MBlue = Value
      Else
        Throw New ArgumentException( _
          "Illegal color value: " & Value)
      End If
    End Set
  End Property
End Class

Module SetProcedure
  Sub Main()
    Dim AColor As New MyColor()

    Try
      AColor.Red = 400
      AColor.Green = 500
      AColor.Blue = 600
    Catch Ex As Exception
      Console.WriteLine(Ex.Message)
    End Try

    Console.WriteLine("Color is {0},{1},{2}", _
      AColor.Red, AColor.Green, AColor.Blue)
    Console.WriteLine("Press any key to continue...")
    Console.ReadLine()
  End Sub
End Module
