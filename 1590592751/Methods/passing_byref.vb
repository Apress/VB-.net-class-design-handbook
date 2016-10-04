Imports System

Module TaxCalculate
  Sub Main()
    Dim GrossPrice As Double = 24.99
    Dim Maths As New MathsClass()

    Console.WriteLine("Calculate Tax ByVal")
    Console.WriteLine("The Gross price is - {0}", GrossPrice)
    Console.WriteLine("The Net price including tax is - {0}", Maths.AddTaxByRef(GrossPrice))
    Console.WriteLine("The Gross price is - {0}", GrossPrice)
  End Sub
End Module

class MathsClass
  Public Function AddTaxByVal(ByVal GrossPrice As Double) As Double
    GrossPrice = GrossPrice * 1.175
    Return GrossPrice
  End Function

  Public Function AddTaxByRef(ByRef NewGrossPrice As Double) as Double
    NewGrossPrice = NewGrossPrice * 1.175
    Return NewGrossPrice
  End Function
End Class