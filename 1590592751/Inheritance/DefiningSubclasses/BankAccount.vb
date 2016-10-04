Imports System

' --------------------------------------------------------------------
' Define the (abstract) superclass for all kinds of bank account
' --------------------------------------------------------------------
Public MustInherit Class BankAccount

    ' Define private fields
    Private mBalance As Double              ' Current balance
    Private mNumber As Integer              ' Unique account number
    Private Shared mNextNumber As Integer   ' Generate account numbers

    ' Define a protected constructor for this abstract class
    Protected Sub New(ByVal Balance As Double)
        mBalance = Balance
        mNumber = mNextNumber
        mNextNumber += 1
    End Sub

    ' Define a non-overridable instance method
    Public Function Debit(ByVal Amount As Double) As Boolean
        If Amount <= MaxSingleDebit And Amount <= Funds Then
            mBalance -= Amount
            Return True
        Else
            Return False
        End If
    End Function

    ' Define another non-overridable instance method
    Public Sub Credit(ByVal Amount As Double)
        mBalance += Amount
    End Sub

    ' Define a shared property (all shared properties are non-overridable)
    Public Shared ReadOnly Property NextNumber() As Integer
        Get
            Return mNextNumber
        End Get
    End Property

    ' Define an overridable instance method
    Public Overridable Sub PrintStatement()
        Console.WriteLine("Account number: {0}", mNumber)
        Console.WriteLine("Balance: ${0}", mBalance)
    End Sub

    ' Define an overridable instance property
    Protected Overridable ReadOnly Property Funds() As Double
        Get
            Return mBalance
        End Get
    End Property

    ' Define an abstract instance method
    Public MustOverride Sub PrintSpecialComments()

    ' Define an abstract instance property
    Public MustOverride ReadOnly Property MaxSingleDebit() As Double

End Class

