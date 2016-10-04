Imports System                  ' For Console class, etc.
Imports System.Collections      ' For Hashtable class

'------------------------------------------------------------------------
' Define the Books namespace
'------------------------------------------------------------------------
Namespace Books

    '--------------------------------------------------------------------
    ' Inventory is a singleton class, and keeps a list of books
    '--------------------------------------------------------------------
    Public Class Inventory

        ' Declare a singleton instance of this class
        Shared Private mInstance As Inventory

        ' Collection of books
        Private mLibraryBooks As Hashtable

        ' Private constructor
        Private Sub New()
            mLibraryBooks = New Hashtable()
	End Sub

        ' Shared property, to get the singleton instance of Inventory
        Public Shared ReadOnly Property Instance() As Inventory
            Get
                ' Create singleton object if it doesn't yet exist
                If mInstance Is Nothing
                    mInstance = New Inventory()
                End If
                Return mInstance
            End Get
        End Property

        ' Return the book with the specified book ID
        Public Default Property LibraryBook(ByVal BookID As Integer) As Book
            Get
                Return mLibraryBooks(BookID)
            End Get

            Set (ByVal Value As Book)
                mLibraryBooks(bookID) = Value
            End Set
        End Property

    End Class

    '--------------------------------------------------------------------
    ' The Book class represents a particular book owned by the library
    '--------------------------------------------------------------------
    Public Class Book

        ' Title and author
        Private mTitle As String
        Private mAuthor As String

        ' Constructor
        Public Sub New(ByVal Title As String, ByVal Author As String)
            mTitle = Title
            mAuthor = Author
	End Sub

        ' Return textual representation of book information
        Public Overrides Function ToString() As String
            Return mTitle & ", written by: " & mAuthor
        End Function

    End Class

End Namespace
