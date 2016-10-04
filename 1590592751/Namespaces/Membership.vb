Imports System
Imports System.Collections

'------------------------------------------------------------------------
' Define the Membership namespace
'------------------------------------------------------------------------
Namespace Membership

    '--------------------------------------------------------------------
    ' MemberManager is a singleton class, and keeps a list of members
    '--------------------------------------------------------------------
    Public Class MemberManager

        ' Declare a singleton instance of this class
        Shared Private mInstance As MemberManager

        ' Collection of members
        Private mLibraryMembers As Hashtable

        ' Private constructor
        Private Sub New()
            mLibraryMembers = New Hashtable()
	End Sub

        ' Shared property, to get the singleton instance of MemberManager
        Public Shared ReadOnly Property Instance() As MemberManager
            Get
                ' Create singleton object if it doesn't yet exist
                If mInstance Is Nothing
                    mInstance = New MemberManager()
                End If
                Return mInstance
            End Get
        End Property

        ' Return the member with the specified member ID
        Public Default Property LibraryMember(ByVal MemberID As Integer) _ 
                                                                 As Member
            Get
                Return mLibraryMembers(MemberID)
            End Get

            Set (ByVal Value As Member)
                mLibraryMembers(MemberID) = Value
            End Set
        End Property

    End Class

    '--------------------------------------------------------------------
    ' The Member class represents a person who is a member of the library
    '--------------------------------------------------------------------
    Public Class Member

        ' Name and address
        Private mName As String
        Private mAddress As Address

        ' Constructor
        Public Sub New(ByVal Name As String, _
                       ByVal Street As String, _
                       ByVal City As String)
            mName = Name
            mAddress = New Address(Street, City)
	End Sub

        ' Return textual representation of member information
        Public Overrides Function ToString() As String
            Return mName & ", address: " & mAddress.ToString()
        End Function

    End Class

    '--------------------------------------------------------------------
    ' The Address class represents a person's address
    '--------------------------------------------------------------------
    Public Class Address

        ' Street and city
        Private mStreet As String
        Private mCity As String

        ' Constructor
        Public Sub New(ByVal Street As String, ByVal City As String)
            mStreet = Street 
            mCity = City
	End Sub

        ' Return textual representation of address information
        Public Overrides Function ToString() As String
            Return mStreet & ", " & mCity
        End Function

    End Class

End Namespace
