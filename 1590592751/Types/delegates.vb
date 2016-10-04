'delegates.vb
Imports System

Module MyModule

  Public Class Trigonometry
    Delegate Function TrigOp(ByVal radians As Double) _ 
      As Double

    ' Perform the operation indicated by "op"
    Private Sub PerformOp(ByVal op As TrigOp)

      ' Get the angle and convert it from degrees into radians
      Console.Write("Enter an Angle (in degrees): ")
      Dim angle As Double = Console.ReadLine
      Dim radians As Double
      radians = (angle / 360) * 2 * Math.PI

      ' Invoke function specified by the "op" delegate
      Dim result As Double
      result = op.Invoke(radians)

      ' Round result to 4 figures, and display it
      result = Math.Round(result, 4)
      Console.Writeline("Result = " & result.ToString())

 End Sub


  Sub Main()
    Console.WriteLine("Enter Operation to Perform")
    Console.Write("Sin, Cos, or Tan: ")
    Dim operation As String = Console.ReadLine

    Select Case operation
      Case "Sin"
        Trig.PerformOp(New Trigonometry.TrigOp(AddressOf Math.Sin))
      Case "Cos"
        Trig.PerformOp(New Trigonometry.TrigOp(AddressOf Math.Cos))
      Case "Tan"
        Trig.PerformOp(New Trigonometry.TrigOp(AddressOf Math.Tan))
      Case Else
        Console.WriteLine("Not a valid operation")
    End Select
  End Sub
End module
