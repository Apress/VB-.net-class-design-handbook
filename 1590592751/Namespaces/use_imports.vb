Imports MyNamespace1
Imports MyNamespace1.MyNestedNamespace1
Imports MyNamespace2.MyNestedNamespace2

Public Class UseImports

    ' Entry point for this application
    Public Shared Sub Main()

        ' Access MyClassA directly
        Dim a As New MyClassA()

        ' Access MyClassB directly
        Dim b As New MyClassB()

        ' Access MyClassC directly
        Dim c As New MyClassC()

    End Sub

End Class