Imports System                  ' For Console class, etc.
Imports System.Collections      ' For Hashtable class
Imports Microsoft.VisualBasic   ' For vbCrLf constant

' Import the other namespaces in our application
Imports Membership
Imports Books


'------------------------------------------------------------------------
' Define the Loans namespace
'------------------------------------------------------------------------
Namespace Loans

    '--------------------------------------------------------------------
    ' LoanManager is a singleton class, and keeps a list of loans
    '--------------------------------------------------------------------
    Public Class LoanManager

        ' Singleton instance of this class
        Shared Private mInstance As LoanManager

        ' Collection of loans
        Private mLoans As Hashtable

        ' Private constructor
        Private Sub New()
            mLoans = New Hashtable()
	End Sub

        ' Shared property, to get the singleton instance of LoanManager
        Public Shared ReadOnly Property Instance() As LoanManager
            Get
                ' Create singleton object if it doesn't yet exist
                If mInstance Is Nothing
                    mInstance = New LoanManager()
                End If
                Return mInstance
            End Get
        End Property

        ' Allow a book to be borrowed by a member
        Public Sub BorrowBook(ByVal BookID As Integer, ByVal MemberID As Integer) 

            ' Get Inventory and MemberManager (singleton objects)
            Dim inv As Inventory = Inventory.Instance
            Dim mem As MemberManager = MemberManager.Instance

            ' Get the requested Book and Member
            Dim TheBook As Book = inv(BookID)
            Dim TheMember As Member = mem(MemberID)

            ' Create a New Loan, and insert into Hashtable
            If (Not TheBook Is Nothing) And (Not TheMember is Nothing)
                Dim theLoan As New Loan(TheBook, TheMember)
                mLoans(BookID) = theLoan
                Console.WriteLine("{0}", theLoan)
            Else
                Console.WriteLine("Cannot borrow book")
            End If
       
        End Sub

        ' Return a book (with specified book ID)
        Public Sub ReturnBook(ByVal BookID As Integer)

            ' Remove the Loan from the Hashtable
            If mLoans.ContainsKey(BookID)
                mLoans.Remove(BookID)
                Console.WriteLine("Book {0} has been returned", BookID)
            Else
                Console.WriteLine("Cannot return book")
            End If
       
        End Sub

    End Class

    '--------------------------------------------------------------------
    ' The Loan class represents a loan of a book by a member
    '--------------------------------------------------------------------
    Public Class Loan

        ' References to the book and the member
        Private mTheBook As Book
        Private mTheMember As Member

        Public Sub New(ByVal TheBook As Book, ByVal TheMember As Member)
            mTheBook = TheBook
            mTheMember = TheMember
	End Sub

        ' Return textual representation of loan information
        Public Overrides Function ToString() As String
            Return "Book: " & mTheBook.ToString() & vbCrLf & _
                   "Borrowed by: " & mTheMember.ToString() & vbCrLf 
        End Function

    End Class

End Namespace
