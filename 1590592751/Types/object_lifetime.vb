' object_lifetime.vb

Imports System
Imports Microsoft.VisualBasic

Module MyModule

  Class MyClass1
    Implements IDisposable

    ' Some data, and a flag to indicate if disposed
    Private name As String
    Private disposed As Boolean

    ' Constructor
    Public Sub New(ByVal n As String)
      name = n
      disposed = False
      Console.WriteLine("Constructor for {0}", name)
    End Sub

    Public Sub CheckDisposal()
      If Not disposed
         Console.WriteLine("{0} still in use", name)
      End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
      If Not disposed Then
        ' Tidy up object...
        Console.WriteLine("Dispose for {0}" & vbCrLf, name)
        ' Prevent multiple disposals
        disposed = True
        ' Suppress finalization for this object
        GC.SuppressFinalize(Me)
      End If
    End Sub

    Protected Overrides Sub Finalize()
      Console.WriteLine("Destructor for {0}", name)
      Dispose()
    End Sub
  End Class


  Sub Main()

    ' Create an object, then dispose it immediately
    Dim object1 As New MyClass1(1)
    object1. CheckDisposal ()
    object1.Dispose()

    ' Call method on disposed object (does nothing)
    object1.CheckDisposal()

    ' Try to dispose object again (no need really...)
    object1.Dispose()

    ' Create another object, but don't dispose it
    Dim object2 As New MyClass1(2)
    Console.WriteLine("The end is nigh")

  End Sub
End Module
