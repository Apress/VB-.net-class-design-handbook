Imports System

' --------------------------------------------------------------------
' Define a delegate type that we can use for all interest-rate events
' --------------------------------------------------------------------
Public Delegate Sub InterestRateEventHandler(ByVal NewValue As Double)

' --------------------------------------------------------------------
' Define the bank account class
' --------------------------------------------------------------------
Public Class BankAccount

    Public Shared Event RateChanged As InterestRateEventHandler
    Public Shared Event ThresholdChanged As InterestRateEventHandler

    ' Plus other members...

End Class



