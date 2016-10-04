Imports System

' --------------------------------------------------------------------
' Define a delegate type for all events from BankAccount instances
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

    ' Private fields for this BankAccount instance
    Private mHolder As String
    Private mBalance As Double

    ' Constructor
    Public Sub New(ByVal Holder As String, ByVal Balance As Double)
        mHolder = Holder
        mBalance = Balance
    End Sub

    ' Debit money from account 
    Public Sub Debit(ByVal Amount As Double)

        mBalance -= Amount

        ' Raise event if account is overdrawn (discussed later)
        If (mBalance < 0) Then
            Dim Args As New BankAccountEventArgs(mHolder, _
                                                 Amount, _
                                                 DateTime.Now)
            RaiseEvent Overdrawn(Me, Args)
        End If

    End Sub

    ' Credit money into account 
    Public Sub Credit(ByVal Amount As Double)

        mBalance += Amount

        ' Raise event if the amount deposited is suspiciously large!
        If Amount >= 1000000 Then
            Dim Args As New BankAccountEventArgs(mHolder, _
                                                 Amount, _
                                                 DateTime.Now)
            RaiseEvent LargeDeposit(Me, Args)
        End If

    End Sub

    ' Property to get the current balance
    Public ReadOnly Property Balance() As Double
        Get
            Return mBalance
        End Get
    End Property

    ' Displayable representation of account
    Public Overrides Function ToString() As String
        Return mHolder
    End Function

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




