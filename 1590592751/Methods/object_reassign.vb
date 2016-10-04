Imports System
Public Module ClassVsStructure

  Public Enum TravelStatus
    FirstClass = 1
    Economy = 2
  End Enum

  ' Class to define a Passenger as a reference type
  Public Class PassengerClass

    Private m_Name As String
    Private m_Status As TravelStatus

    Public Property Name() As String
      Get
        Return (m_Name)
      End Get
      Set(ByVal Value As String)
        m_Name = Value
      End Set
    End Property

    Public Property Status() As TravelStatus
      Get
        Return (m_Status)
      End Get
      Set(ByVal Value As TravelStatus)
        m_Status = Value
      End Set
    End Property
  End Class

  ' Structure to define a Passenger as a value type
  Public Structure PassengerStruct
    Public Name As String
    Public Status As TravelStatus
  End Structure


  ' Changes the Name property of the Passenger Class ByVal
  Public Sub ChangeName_Obj_ByVal(ByVal details As PassengerClass, _ 
                                  ByVal NewName As String)
    details.Name = NewName
  End Sub

  ' Changes the Name property of the Passenger Class ByRef
  Public Sub ChangeName_Obj_ByRef(ByRef details As PassengerClass, _ 
                                  ByVal NewName As String)
    details.Name = NewName
  End Sub

  ' Changes the Name property of the Passenger Structure ByVal
  Public Sub ChangeName_Struct_ByVal(ByVal details As PassengerStruct, _
                                    ByVal NewName As String)
    details.Name = NewName
  End Sub

  ' Changes the Name property of the Passenger Structure ByRef
  Public Sub ChangeName_Struct_ByRef(ByRef details As PassengerStruct, _
                                    ByVal NewName As String)
    details.Name = NewName
  End Sub

  ' Upgrades the Object ByVal
  Public Sub UpgradeCustomer_ByVal(ByVal details As PassengerClass)

    Dim newDetails As PassengerClass = New PassengerClass()
    newDetails.Name = details.Name
    newDetails.Status = TravelStatus.FirstClass

    ' Assign ByVal parameter to local object
    details = newDetails

  End Sub

  ' Upgrades the Object ByRef
  Public Sub UpgradeCustomer_ByRef(ByRef details As PassengerClass)

    Dim newDetails As PassengerClass = New PassengerClass()
    newDetails.Name = details.Name
    newDetails.Status = TravelStatus.FirstClass

    ' Assign ByRef parameter to local object
    details = newDetails

  End Sub

  Sub Main()
    Dim passengerObj As PassengerClass = New PassengerClass()
    passengerObj.Name = "Lucy"
    passengerObj.Status = TravelStatus.Economy
    Console.WriteLine("Before - Object, Name & Status - {0}, {1}", _
                      passengerObj.Name, _
                      passengerObj.Status)

  UpgradeCustomer_ByVal(passengerObj)

  Console.WriteLine("After ByVal,    Name & Status - _ {0}, {1}", _
    passengerObj.Name, passengerObj.Status)

  UpgradeCustomer_ByRef(passengerObj)

  Console.WriteLine("After ByRef,    Name & Status - {0}, {1}", _
                    passengerObj.Name, _
                    passengerObj.Status)
  End Sub

End Module
