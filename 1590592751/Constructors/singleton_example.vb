Public Class StringPooler
  Private Shared SP As StringPooler
  Private Pool as New Collections.ArrayList()

  Private Sub New()
  End Sub 
  
  Public Shared Function Create() As StringPooler
    If SP is Nothing Then SP = New StringPooler() 
    Return SP
  End Function

  Public ReadOnly Property Pool As Collections.ArrayList
    Get
      Return Pool
    End Get
  End Property
End Class

Module SingletonExample
  Sub Main
    Dim CountValue as Integer
    Dim SP As StringPooler = StringPooler.Create()
    Dim SP2 As StringPooler = StringPooler.Create()

    SP.Pool.Add("First")
    SP.Pool.Add("Second")
    SP.Pool.Add("Third")

    For CountValue = 0 To SP2.Pool.Count - 1
      Console.WriteLine(SP2.Pool.Item(CountValue).ToString())
    Next
  End Sub
End Module
