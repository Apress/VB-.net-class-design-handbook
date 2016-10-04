'class_members.vb
Class AClass

   ' Variable (usually private, for encapsulation)
   Private AVariable As Integer

   ' Property (usually public, for ease of use)
   Public Property AProperty() As Integer
      Get
         Return AVariable
      End Get
      Set(ByVal number As Integer)
         AVariable = number
      End Set
   End Property

   ' Constant (class-wide read-only value)
   Public Const AConstant As Integer = 42

   ' Event (to alert event receiver objects)
   Public Event AnEvent()

   ' Method
   Public Sub AMethod()
      ' Method implementation code
   End Sub

   ' Constructor (to initialize new objects)
   Public Sub New()
      ' Constructor implementation code
   End Sub

   ' Finalization method (to tidy-up objects)
   Protected Overrides Sub Finalize()
      ' Finalization code
   End Sub

   ' Nested class definition
   Private Class ANestedClass
      ' Class definition
   End Class

End Class
