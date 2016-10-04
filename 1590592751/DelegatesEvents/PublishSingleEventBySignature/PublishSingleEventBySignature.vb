Imports System

Public Class BankAccount

    Friend Event Overdrawn(ByVal AccountHolder As String, _
                           ByVal HowMuchOverdrawn As Double, _
                           ByVal WhenOverdrawn As DateTime)

    ' Plus other members...

End Class

