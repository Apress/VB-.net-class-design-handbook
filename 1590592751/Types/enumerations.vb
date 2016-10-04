' enumerations.vb
Imports System

Module MyModule

  Enum Medal As Short
    Gold
    Silver
    Bronze
  End Enum

  Sub Main()
    Dim myMedal As Medal = Medal.Bronze
    Console.WriteLine("My medal: " & myMedal.ToString)
End Sub

End Module
