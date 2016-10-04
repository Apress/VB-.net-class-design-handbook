Imports System

Module Bank
  Sub Main()
    Dim acct As New Account()
    Console.WriteLine(acct.AccountHolder)

    'fails since not accessible
    'Console.WriteLine(acct.retrieved)   

    'Since retrieved is protected, CheckingAccount will be able
    'to access it since it derives from Account
    Dim cAcct As New CheckingAccount()
  End Sub
End Module

Public Class CheckingAccount
  Inherits Account
  Sub New()
    MyBase.New
    'Allowed since we derive from Account
    Console.WriteLine(MyBase.retrieved) 
    Console.WriteLine(MyBase.AccountHolder)
  End Sub
End Class

Public Class Account
  Protected retrieved As DateTime
  Private acctHolder As String
  
  Public Sub New()
    retrieved = DateTime.Now()
    acctHolder = "DEFAULT"
    'Normally Retrieve from DB
  End Sub
  
  Friend Property AccountHolder As String
    Get
      Return acctHolder
    End Get
    Set(ByVal Value As String) 
      acctHolder = Value
    End Set
  End Property
End Class
