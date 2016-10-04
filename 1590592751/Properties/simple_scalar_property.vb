Imports System

Class Person
  Private MName As String

  Public Property Name() As String
    Get
      Return MName
    End Get

    Set(ByVal Value As String)
      MName = Value
    End Set
  End Property
End Class

Module SimpleScalarProperty
  Sub Main()
    Dim APerson As New Person()
    APerson.Name = "Roger"

    Console.WriteLine("{0}", APerson.Name)
  End Sub
End Module