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


  Sub Main()

    Dim passengerObj As PassengerClass = New PassengerClass()
    Dim passengerStr As PassengerStruct = New PassengerStruct()
    passengerObj.Name = "Lucy"
    passengerObj.Status = TravelStatus.Economy
    passengerStr.Name = "Kate"
    passengerStr.Status = TravelStatus.Economy


    Console.WriteLine("Before - Object, Name & Status - {0}, {1}", _
                      passengerObj.Name, _
                      passengerObj.Status)
    Console.WriteLine("Before - Structure, Name & Status - {0}, " + _ 
                      "{1}", passengerStr.Name, _ 
                      passengerStr.Status)
    Console.WriteLine()


    ChangeName_Obj_ByVal(passengerObj, "Lucy (Changed ByVal)")


    ChangeName_Struct_ByVal(passengerStr, "Kate (Changed ByVal)")
   
    Console.WriteLine("Test 1 - Object,    Name & Status - {0}, " + _ 
                      "{1}", passengerObj.Name, _
                      passengerObj.Status)
    Console.WriteLine("Test 2 - Structure, Name & Status - {0}, " + _ 
                      "{1}", passengerStr.Name, 
                      passengerStr.Status)
    Console.WriteLine()


    ChangeName_Obj_ByRef(passengerObj, "Lucy (Changed ByRef)")


    ChangeName_Struct_ByRef(passengerStr, "Kate (Changed ByRef)")
    Console.WriteLine("Test 3 - Object,    Name & Status - {0}, " + _ 
                      "{1}", passengerObj.Name, _
                      passengerObj.Status)
    Console.WriteLine("Test 4 - Structure, Name & Status - {0}, " + _ 
                      "{1}", passengerStr.Name, _
                      passengerStr.Status)
    Console.WriteLine()
  End Sub
End Module
