Imports System
Imports System.Collections

Public Interface Countable
  ReadOnly Property Count() As Integer
End Interface

Public Class Account
  Implements Countable

  Protected mTransactions As New ArrayList()

  ReadOnly Property Count() As Integer _
                            Implements Countable.Count
    Get
      Return mTransactions.Count
    End Get
  End Property

  Public Overridable ReadOnly Property Balance() As Double
    Get
      Dim result As Double = 0.0
      Dim i As Integer
      For i = 0 To mTransactions.Count - 1
        result += CDbl(mTransactions(i))
      Next
      Return result
    End Get
  End Property

  Public Sub Deposit(ByVal amount As Double)
    mTransactions.Add(amount)
  End Sub

  Public Sub Withdraw(ByVal amount As Double)
    mTransactions.Add(-amount)
  End Sub
End Class

Public Class BusinessAccount
  Inherits Account

  Private Const mCharge = 2.0

  Public Overrides ReadOnly Property Balance() As Double
    Get
      Return MyBase.Balance - (Count * mCharge)
    End Get
  End Property
End Class

Module InheritanceAndInterfaces
  Sub Main()
    Dim acc1 As New Account()

    acc1.Deposit(200)
    acc1.Withdraw(40)
    acc1.Deposit(30)

    Console.Write("count: {0}, ", acc1.Count)
    Console.WriteLine("balance: {0}", acc1.Balance)

    Dim acc2 As New BusinessAccount()

    acc2.Deposit(200)
    acc2.Withdraw(40)
    acc2.Deposit(30)

    Console.Write("count: {0}, ", acc2.Count)
    Console.WriteLine("balance: {0}", acc2.Balance)
  End Sub
End Module
