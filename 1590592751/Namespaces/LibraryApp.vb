Imports System
Imports System.Collections

' Import the other namespaces in our application
Imports Membership
Imports Books
Imports Loans

Public Class LibraryApp

    ' Entry point for this application
    Public Shared Sub Main()

        ' Get a reference to the Inventory object, and add some books
        Dim inv As Inventory = Inventory.Instance
        inv(7167) = new Book("Professional VB.NET", "Rocky Lhotka et. al.")
        inv(5318) = new Book("Professional XML for .NET Developers", "Dinar Dalvi et. al.")

        ' Get a reference to the MemberManager object, and add some members
        Dim mem As MemberManager = MemberManager.Instance
        mem(100) = new Member("Emily", "5th Avenue", "New York")
        mem(101) = new Member("Thomas", "Park Lane", "London")

        ' Get a reference to the LoanManager object, and borrow some books
        Dim loanmgr As LoanManager = LoanManager.Instance
        loanmgr.BorrowBook(7167, 100)
        loanmgr.BorrowBook(5318, 101)

        ' Return the books
        loanmgr.ReturnBook(7167)
        loanmgr.ReturnBook(5318)

    End Sub

End Class