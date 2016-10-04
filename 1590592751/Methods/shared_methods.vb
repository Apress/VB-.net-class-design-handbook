Imports System
Imports System.Collections

Module SharedMethods

  Public Class Driver
    Private m_DriverName As String

    Public Shared Function SaveDrivers(ByRef DriverCollection _
                                       As ArrayList) As Integer
      ' Code to save drivers to database should go here
      Console.WriteLine("Saving drivers...")
      Dim objDriver As New Driver()
      For Each objDriver In DriverCollection
        Console.WriteLine("Saving Driver - {0}", objDriver.DriverName)
      Next
        Console.WriteLine()
    End Function

    Public Property DriverName()
      Get
        Return m_DriverName
      End Get
      Set(ByVal Value)
        m_DriverName = Value
      End Set
    End Property
  End Class

  Sub Main()
    ' This is our holding collection
    Dim DriversCol As New ArrayList()

    ' These are the two separate instances of Driver objects
    Dim objDriver1 As New Driver()
    Dim objDriver2 As New Driver()

    ' Set their respective properties
    objDriver1.DriverName = "Kate"
    objDriver2.DriverName = "Lucy"

    ' Add the drivers to the holding collection
    DriversCol.Add(objDriver1)
    DriversCol.Add(objDriver2)

    ' Calling a shared method from the first Driver object
    objDriver1.SaveDrivers(DriversCol)

    ' Calling a method from the second Driver object 
    objDriver2.SaveDrivers(DriversCol)


    Driver.SaveDrivers(DriversCol)

  Console.ReadLine()
  End Sub
End Module
