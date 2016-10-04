' value_type_inheritance.vb

Imports System
Imports Microsoft.VisualBasic

  Structure Money
    Implements IComparable

    ' Private variables
    Private centsAmount As Integer
    Private Const currencySymbol As String = "$"

    ' Public constructors
    Public Sub New(ByVal dollars As Integer, _
                   ByVal cents As Integer)
      Me.centsAmount = (dollars * 100) + cents
    End Sub

    Public Sub New(ByVal amount As Double)
      Me.centsAmount = CInt(amount * 100)
    End Sub

    ' Compare with another Money
    Public Function CompareTo( _
      ByVal other As Object) As Integer _
      Implements IComparable.CompareTo
      Dim m2 As Money = CType(other, Money)
      If Me.centsAmount < m2.centsAmount Then
        Return -1
      ElseIf Me.centsAmount = m2.centsAmount Then
        Return 0
      Else
        Return +1
      End If
    End Function

      ' Return value as a string
    Public Overrides Function ToString() As String
      Return currencySymbol & _
        CStr(Me.centsAmount / 100)
    End Function

  End Structure

Module MyModule
  ' Entry point for the console application
  Sub Main()

    ' Create an array of 5 items (0..4)
    Dim salaries(4) As Money
    salaries(0) = New Money(9.5)
    salaries(1) = New Money(4.8)
    salaries(2) = New Money(8.7)
    salaries(3) = salaries(2)
    salaries(4) = New Money(6.3)

    ' Display unsorted array
    Console.WriteLine("Unsorted array:")
    Dim salary As Money
    For Each salary In salaries
      Console.WriteLine("{0}", salary)
    Next

    ' Sort the array
    Array.Sort(salaries)

    ' Display sorted array
    Console.WriteLine(vbCrLf & "Sorted array:")
    For Each salary In salaries
      Console.WriteLine("{0}", salary)
    Next

  End Sub

End Module
