Imports System
Imports System.Data.OleDb
Imports System.ComponentModel.Component

Class Person
  Private MName As String
  Private MDob As DateTime
  Private MCompany As String

  Public Sub New(ByVal name As String, _
                 ByVal dob As DateTime)

    MName = name
    MDob = dob
    MCompany = "<not read>"
  End Sub

  Public Property Name() As String
    Get
      Return MName
    End Get

    Set(ByVal Value As String)
      MName = Value
    End Set
  End Property

  Public ReadOnly Property Age() As Integer
    Get
      Dim today As DateTime = DateTime.Now

      Dim Years As Integer = _
        DateTime.Now.Year - mDob.Year

      If (today.Month < MDob.Month) Or _
         (today.Month = MDob.Month And _ 
          today.Day < MDob.Day) Then
        Years -= 1
      End If

      Return years
    End Get
  End Property

  Public ReadOnly Property Company() As String
    Get
      If MCompany = "<not read>" Then
        Dim Con As OleDbConnection
        Dim Cmd As OleDbCommand

        Try
          Con = New OleDbConnection( _
            "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Data Source=Northwind.mdb;")
          Con.Open()

          Cmd = New OleDbCommand( _
            "SELECT CompanyName FROM Customers " & _
            "WHERE ContactName='" & MName & "'", con)

          MCompany = cmd.ExecuteScalar()

          If mCompany Is Nothing Then
            MCompany = "<unknown>"
          End If
        Catch Ex As OleDbException
          Console.WriteLine("Error occurred: {0}", Ex.Message)
        Finally
          If Not Con Is Nothing Then
            con.Close()
          End If
        End Try
      End If

      Return MCompany
    End Get
  End Property
End Class

Module GetProcedures
  Sub Main()
    Dim APerson As New Person( _
      "Ann Devon", New DateTime(1964, 12, 3))

    Console.WriteLine("{0} is {1}, works for {2}", _
      APerson.Name, _
      APerson.Age, _
      APerson.Company)
  End Sub
End Module
