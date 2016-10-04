' Import the System namespace, where Object and Type are defined
Imports System

' Define a class (implicitly inherits from System.Object)
Public Class MyClass1
    ' No new members in this simple class
End Class

' Define a class that explicitly inherits from System.Object
Public Class MyClass2
    Inherits Object
    ' No new members in this class, either
End Class

' Define a structure (implicitly inherits from System.ValueType)
Public Structure MyStructure
    Private Data As Integer   ' Structures must have at least one member
End Structure

' Structures cannot explicitly specify a superclass
' Public Structure MyBadStructure
'     Inherits ValueType
'   Private Data As Integer
' End Structure


' Define a class that contains the Main subroutine for this application
Public Class MyApp

    Shared Sub Main()

        ' Create a MyClass1 object, and examine its type and base type
        Dim obj1 As New MyClass1()
        Dim type As Type = obj1.GetType()
        Console.WriteLine("obj1 is an instance of type {0}", type.Name)
        Console.WriteLine("Base type is {0}", type.BaseType)
        Console.WriteLine("------------------------------------------")

        ' Create a MyClass2 object, and examine its type and base type
        Dim obj2 As New MyClass2()
        type = obj2.GetType()
        Console.WriteLine("obj2 is an instance of type {0}", type.Name)
        Console.WriteLine("Base type is {0}", type.BaseType)
        Console.WriteLine("------------------------------------------")

        ' Create a MyStructure object, and examine its type and base type
        Dim val As New MyStructure()
        type = val.GetType()
        Console.WriteLine("val is an instance of type {0}", type.Name)
        Console.WriteLine("Base type is {0}", type.BaseType)
        Console.WriteLine("Base-base type is {0}", type.BaseType.BaseType)
        Console.WriteLine("------------------------------------------")

    End Sub

End Class
