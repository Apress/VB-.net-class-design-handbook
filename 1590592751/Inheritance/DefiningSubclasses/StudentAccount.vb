Imports System

' --------------------------------------------------------------------
' Define StudentAccount as a concrete subclass of BankAccount
' --------------------------------------------------------------------
Public Class StudentAccount
    Inherits BankAccount

    ' Define private fields
    Private Shadows mOverdraftLimit As Double       ' Overdraft limit

    ' Define a public constructor for this concrete class
    Public Sub New(ByVal Balance As Double, ByVal OverdraftLimit As Double)
        MyBase.New(Balance)
        mOverdraftLimit = OverdraftLimit
    End Sub

    ' Define an additional method
    Public Shadows Sub IncreaseLimit(ByVal Amount As Double)
        mOverdraftLimit += Amount
    End Sub

    ' Override an Overridable method from the superclass
    Public Overrides Sub PrintStatement()
        MyBase.PrintStatement()
        Console.WriteLine("Overdraft limit: ${0}", mOverdraftLimit)
    End Sub

    ' Override an Overridable property from the superclass
    Protected Overrides ReadOnly Property Funds() As Double
        Get
            Return MyBase.Funds + mOverdraftLimit
        End Get
    End Property

    ' Override a MustOverride method from the superclass
    Public Overrides Sub PrintSpecialComments()
        Console.WriteLine("Student overdraft limit: ${0}", mOverdraftLimit)
    End Sub

    ' Override a MustOverride property from the superclass
    Public Overrides ReadOnly Property MaxSingleDebit() As Double
        Get
            Return 50
        End Get
    End Property

End Class
