Public Class UseFullyQualified

    ' Entry point for this application
    Public Shared Sub Main()

        ' Access MyClassA in MyNamespace1
        Dim a As New MyNamespace1.MyClassA()

        ' Access MyClassB in MyNamespace1.MyNestedNamespace1
        Dim b As New MyNamespace1.MyNestedNamespace1.MyClassB()

        ' Access MyClassC in MyNamespace2.MyNestedNamespace2
        Dim c As New MyNamespace2.MyNestedNamespace2.MyClassC()

    End Sub

End Class