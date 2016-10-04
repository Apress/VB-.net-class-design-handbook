Public Class CustomPrinter
  Private Sub New()
  End Sub

  Public Shared Function QuoteIt(ToQuote as String, _
                                 Author As String) As String
    Return """" & ToQuote & """  - " & Author
  End Function
  
  Public Shared Function UpperLower(ToChange as String) As String
    Dim CharacterPointer as Integer
    Dim SB as New Text.StringBuilder(ToChange)

    For CharacterPointer = 0 To ToChange.Length - 1
      If CharacterPointer Mod 2 = 0 Then 
        SB.Chars(CharacterPointer) = SB.Chars( _
          CharacterPointer).ToUpper(SB.Chars(CharacterPointer))
      Else
        SB.Chars(CharacterPointer) = SB.Chars( _
         CharacterPointer).ToLower(SB.Chars(CharacterPointer))
      End If
    Next

    Return SB.ToString()
  End Function
End Class

Module PrivateConstructor
  Sub Main
    Console.WriteLine(CustomPrinter.QuoteIt( _
      "640K ought to be enough for anybody.", "Bill Gates"))
    Console.WriteLine(CustomPrinter.UpperLower("Wrox Press"))
  End Sub
End Module
