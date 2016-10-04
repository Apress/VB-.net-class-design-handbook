Imports System

' --------------------------------------------------------------------
' Define a delegate type that we can use for all the events
' --------------------------------------------------------------------
Public Delegate Sub BankAccountEventHandler( _
                           ByVal Source As BankAccount, _
                           ByVal e As BankAccountEventArgs)

' --------------------------------------------------------------------
' Define the bank account class
' --------------------------------------------------------------------
Public Class BankAccount

    ' Define events, using our delegate type to denote the signatures
    Public Event Overdrawn As BankAccountEventHandler
    Public Event LargeDeposit As BankAccountEventHandler

    ' Plus other members...

End Class

' --------------------------------------------------------------------
' Define a class to hold contextual information about events
' --------------------------------------------------------------------
Public Class BankAccountEventArgs
    Inherits EventArgs

    ' Private fields
    Private mAccountHolder As String
    Private mAmount As Double
    Private mTimeStamp As DateTime

    ' Constructor, to initialize private fields
    Public Sub New(ByVal AccountHolder As String, _
                   ByVal Amount As Double, _
                   ByVal TimeStamp As DateTime)

        mAccountHolder = AccountHolder
        mAmount = Amount
        mTimeStamp = TimeStamp

    End Sub

    ' Properties, to get the values held in the private fields
    Public ReadOnly Property AccountHolder() As String
        Get
            Return mAccountHolder
        End Get
    End Property

    Public ReadOnly Property Amount() As Double
        Get
            Return mAmount
        End Get
    End Property

    Public ReadOnly Property TimeStamp() As DateTime
        Get
            Return mTimeStamp
        End Get
    End Property

End Class




