Imports System
Imports System.Collections

Class HashtableProperties
  Shared Sub Main()

    Dim DialCodes As New Hashtable()

    DialCodes.Item("USA") = 1
    DialCodes.Item("UK") = 44
    DialCodes.Item("Austria") = 43
    DialCodes.Item("France") = 33
    DialCodes.Item("Italy") = 39

    Console.Write("Please enter a country name: ")
    Dim Country As String = Console.ReadLine()

    Dim Code As Integer = DialCodes.Item(Country)
    If Code = 0 Then
      Console.WriteLine("Code for {0} is not known", Country)
    Else
      Console.WriteLine("Code for {0} is {1}", Country, Code)
    End If
  End Sub
End Class
