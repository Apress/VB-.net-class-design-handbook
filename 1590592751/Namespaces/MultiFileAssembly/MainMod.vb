Imports System

Public Module MyModule
  Sub Main()
    Console.WriteLine("Select an option: ")
    Console.WriteLine("  1  C to F")
    Console.WriteLine("  2  F to C")
    Console.WriteLine("  3  Miles to Km")
    Console.WriteLine("  4  Km to Miles")
    Console.Write("=>")

    Dim Input As String = Console.ReadLine()
    Dim Opt As Integer = Integer.Parse(Input)

    Console.Write("Value to convert: ")
    Input = Console.ReadLine()
    Dim Value As Double = Double.Parse(Input)

    Dim Res As Double
    If Opt = 1 Then
      Res = TempConverter.CelsiusToFahr(Value)
    ElseIf opt = 2 Then
      Res = TempConverter.FahrToCelsius(Value)
    ElseIf opt = 3 Then
      Res = DistanceConverter.MileToKm(Value)
    ElseIf opt = 4 Then
      Res = DistanceConverter.KmToMile(Value)
    Else
      Console.WriteLine("Invalid option")
      Exit Sub
    End If
    Console.WriteLine("{0}", Math.Round(Res, 2))
  End Sub
End Module
