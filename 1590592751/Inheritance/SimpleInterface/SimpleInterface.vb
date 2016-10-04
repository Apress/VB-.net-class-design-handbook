Imports System
Imports Microsoft.VisualBasic

' --------------------------------------------------------------------
' Define an interface 
' --------------------------------------------------------------------
Public Interface IPrintable
    Sub Print()
End Interface

' --------------------------------------------------------------------
' Define an InsuranceContract class, which implements IPrintable
' --------------------------------------------------------------------
Public Class InsuranceContract
    Implements IPrintable

    Private mName As String             ' Name of insured person
    Private mAmount As Double           ' Amount insured for
    Private mPremium As Double          ' Annual insurance premium 

    ' Constructor
    Public Sub New(ByVal Name As String, _
                   ByVal Amount As Double, _
                   ByVal Premium As Double)
        mName = Name
        mAmount = Amount
        mPremium = Premium
    End Sub

    ' Implement the Print method (from IPrintable)
    Public Sub Print() Implements IPrintable.Print
        Console.WriteLine("Printing an Insurance Contract")
        Console.WriteLine("{0} insured for ${1}, premium ${2}" & vbCrLf, _
                           mName, mAmount, mPremium)
    End Sub

    ' Additional methods etc. as required
    Public Sub AdjustPremium(ByVal PremiumDelta As Double)
        mPremium += PremiumDelta
    End Sub

End Class

' --------------------------------------------------------------------
' Define a Trade class, which implements IPrintable
' --------------------------------------------------------------------
Public Class Trade
    Implements IPrintable

    Public Enum BuyOrSell
        Buy
        Sell
    End Enum

    Private mTypeOfTrade As BuyOrSell   ' Is this a "buy" or "sell" trade?
    Private mTicker As String           ' Ticker for the stock being traded
    Private mUnitPrice As Double        ' Unit price for the stock 
    Private mQuantity As Integer        ' Number of stocks being traded

    ' Constructor
    Public Sub New(ByVal TypeOfTrade As BuyOrSell, _
                   ByVal Ticker As String, _
                   ByVal UnitPrice As Double, _
                   ByVal Quantity As Integer)
        mTypeOfTrade = TypeOfTrade
        mTicker = Ticker
        mUnitPrice = UnitPrice
        mQuantity = Quantity
    End Sub

    ' Implement the Print method (from IPrintable)
    Public Sub Print() Implements IPrintable.Print
        Console.WriteLine("Printing a Trade")
        Console.WriteLine("{0} {1} stocks of {2}, value ${3}" & vbCrLf, _
                           mTypeOfTrade, mQuantity, mTicker, TotalValue())
    End Sub

    ' Additional methods etc. as required
    Private Function TotalValue() As Double
        Return mUnitPrice * mQuantity
    End Function

End Class

' --------------------------------------------------------------------
' Define a class that contains the Main subroutine for this application
' --------------------------------------------------------------------
Public Class MyApp

    Shared Sub Main()

        ' Create an InsuranceContract object and a Trade object
        Dim aContract As New InsuranceContract("Tom Evans", 250000, 450)
        Dim aTrade As New Trade(Trade.BuyOrSell.Buy, "WROX", 9.5, 100000)

        ' Pass objects into a generic method, which accepts any object
        ' that implements the IPrintable interface
        MyGenericMethod(aContract)
        MyGenericMethod(aTrade)

    End Sub

    Shared Sub MyGenericMethod(ByVal aPrintableObject As IPrintable)

        ' We know the aPrintableObject parameter has a Print method
        aPrintableObject.Print()

    End Sub

End Class
