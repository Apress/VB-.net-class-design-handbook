Imports System
Imports System.Collections
Imports System.Threading

' --------------------------------------------------------------------
' Define an interface with all kinds of allowable members
' --------------------------------------------------------------------
Public Interface ICalculable

    ' A method, to perform a calculation
    Sub PerformCalculation()

    ' An event, to indicate the calculation is complete
    Event CalculationComplete(ByVal Src As ICalculable)

    ' A scalar property, to indicate how many results were calculated
    ReadOnly Property Count() As Integer

    ' An indexed property, to get the results of the calculation
    Default ReadOnly Property Results(ByVal Index As Integer) As Object

End Interface

' --------------------------------------------------------------------
' Define a class that implements the interface
' --------------------------------------------------------------------
Public Class PrimeNumberFinder
    Implements ICalculable

    Private mPrimesRequired As Integer  ' How many primes required?
    Private mResults As ArrayList       ' Prime numbers 

    ' Constructor
    Public Sub New(ByVal PrimesRequired As Double)
        mPrimesRequired = PrimesRequired
        mResults = New ArrayList()
    End Sub

    ' Implement the PerformCalculation method, to find 'n' primes
    Public Sub PerformCalculation() _
        Implements ICalculable.PerformCalculation

        ' How many prime numbers found so far
        Dim PrimeCount As Integer = 0

        ' Loop through all numbers, to see if they are prime
        Dim Number As Integer
        For Number = 2 To Integer.MaxValue

            ' Does this number have a factor?
            Dim I As Integer
            For I = 2 To Number - 1
                If Number Mod I = 0 Then
                    ' I is factor of Number, so Number is not prime
                    Exit For
                End If
            Next

            ' Did we reach the end of the loop without finding a factor?
            If I = Number Then

                ' Number is prime, so add it to the ArrayList
                mResults.Add(Number)
                PrimeCount += 1

                ' Have we found all the prime numbers we need?
                If PrimeCount = mPrimesRequired Then

                    ' Raise event, to indicate the calculation is complete
                    RaiseEvent CalculationComplete(Me)
                    Exit Sub

                End If
            End If
        Next

    End Sub

    ' Implement the CalculationComplete event
    Public Event CalculationComplete(ByVal Src As ICalculable) _
        Implements ICalculable.CalculationComplete

    ' Implement the Count scalar property, to get number of primes found
    ReadOnly Property Count() As Integer Implements ICalculable.Count
        Get
            Return mResults.Count
        End Get
    End Property

    ' Implement the Results indexed property, to get a specified result
    Default ReadOnly Property Results(ByVal Index As Integer) As Object _
        Implements ICalculable.Results

        Get
            Return mResults(Index)
        End Get

    End Property

End Class

' --------------------------------------------------------------------
' Define a class that contains the Main subroutine for this application
' --------------------------------------------------------------------
Public Class MainApp

    ' Entry point for this application
    Shared Sub Main()

        ' Find the first 5 prime numbers
        Dim prime5 As New PrimeNumberFinder(5)
        AddHandler prime5.CalculationComplete, AddressOf MyHandler
        Dim t As New Thread(AddressOf prime5.PerformCalculation)
        t.Start()

        ' Find the first 20 prime numbers
        Dim prime20 As New PrimeNumberFinder(20)
        AddHandler prime20.CalculationComplete, AddressOf MyHandler
        t = New Thread(AddressOf prime20.PerformCalculation)
        t.Start()

    End Sub

    ' Event handler method, for events from ICalculable objects
    Shared Sub MyHandler(ByVal Src As ICalculable)

        ' Lock the Console.Out object to prevent synchronization problems
        Monitor.Enter(Console.Out)

        ' Display the results from the ICalculable object
        Console.WriteLine("First {0} prime numbers", Src.Count)
        Dim I As Integer
        For I = 0 To Src.Count - 1
            Console.Write("{0} ", Src.Results(I))
        Next
        Console.WriteLine()

        ' Unlock the Console.Out object
        Monitor.Exit(Console.Out)

    End Sub

End Class
