'value_types.vb
Structure Money

   ' Private instance variable
   Private centsAmount As Integer

   ' Private class variable
   Private Const currencySymbol As String = "$"

   ' Public constructor
   Public Sub New(ByVal dollars As Integer, _
                  ByVal cents As Integer)
      Me.centsAmount = (dollars * 100) + cents
   End Sub

   ' Another public constructor
   Public Sub New(ByVal amount As Double)
       Me.centsAmount = CInt(amount * 100)
   End Sub

End Structure

Module MyModule

   ' Entry point for the console application
   Sub Main()
       Dim freebie As Money
       Dim salary As Money = New Money(20000, 0)
       Dim carPrice As Money = New Money(34999.95)
   End Sub

End Module
