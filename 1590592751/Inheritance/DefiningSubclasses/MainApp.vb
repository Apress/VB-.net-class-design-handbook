Imports System
Imports Microsoft.VisualBasic

' ---------------------------------------------------------------------
' Define a class that contains the Main subroutine for this application
' ---------------------------------------------------------------------
Public Class MyApp

    ' Entry point for this application
    Shared Sub Main()

        ' Create a StudentAccount object, and pass it a subroutine 
        ' that expects a StudentAccount
        Dim studentAccount0 As New StudentAccount(3000, 300)
        UseStudentAccount(studentAccount0)

        ' Create another StudentAccount object, and pass it to a subroutine
        ' that takes "any kind of" BankAccount object
        Dim studentAccount1 As New StudentAccount(5000, 500)
        UseAnyKindOfAccount(studentAccount1)

    End Sub

    ' This method specifically takes a StudentAccount object
    Shared Sub UseStudentAccount(ByVal aStudentAccount As StudentAccount)

        Console.WriteLine("Using a StudentAccount object")

        ' Use members originally defined in BankAccount
        aStudentAccount.Debit(50)
        aStudentAccount.Credit(100)
        aStudentAccount.PrintStatement()
        aStudentAccount.PrintSpecialComments()
        Console.WriteLine("Maximum single withdrawal: ${0}", _
                           aStudentAccount.MaxSingleDebit)

        ' Use new members introduced in SavingsAccount
        aStudentAccount.IncreaseLimit(200)
        aStudentAccount.PrintSpecialComments()  ' Verify limit is updated

    End Sub

    ' This method takes "any kind of" BankAccount object 
    Shared Sub UseAnyKindOfAccount(ByVal anAccount As BankAccount)

        Console.WriteLine(vbCrLf & "Using a kind of BankAccount object")

        ' Use members originally defined in BankAccount
        anAccount.Debit(50)
        anAccount.Credit(100)
        anAccount.PrintStatement()
        anAccount.PrintSpecialComments()
        Console.WriteLine("Maximum single withdrawal: ${0}", _
                           anAccount.MaxSingleDebit)

    End Sub

End Class
