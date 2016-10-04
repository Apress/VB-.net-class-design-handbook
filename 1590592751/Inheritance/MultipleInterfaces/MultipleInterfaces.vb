Imports System
Imports Microsoft.VisualBasic

' --------------------------------------------------------------------
' Interface for devices that can be switched on and off immediately
' --------------------------------------------------------------------
Public Interface ISwitchable
    Sub SwitchOn()
    Sub SwitchOff()
    ReadOnly Property IsOn() As Boolean
End Interface

' --------------------------------------------------------------------
' Interface for devices that can be switched on and off at specific times
' --------------------------------------------------------------------
Public Interface ITimeable
    Sub SwitchOn(ByVal HourOn As Integer)
    Sub SwitchOff(ByVal HourOff As Integer)
    ReadOnly Property IsOn() As Boolean
End Interface

' --------------------------------------------------------------------
' Define a class that implements both interfaces
' --------------------------------------------------------------------
Public Class TimerSwitch
    Implements ISwitchable
    Implements ITimeable

    Private mAlwaysOn As Boolean            ' Is the device on constantly?
    Private mHourOn, mHourOff As Integer    ' Time to go on/off

    ' Implement the SwitchOn method from ISwitchable
    Public Sub SwitchOnConstant() Implements ISwitchable.SwitchOn
        mAlwaysOn = True
        Console.WriteLine("Device is always on")
    End Sub

    ' Implement the SwitchOff method from ISwitchable
    Public Sub SwitchOffConstant() Implements ISwitchable.SwitchOff
        mAlwaysOn = False
        Console.WriteLine("Device is not always on")
    End Sub

    ' Implement the SwitchOn method from ITimeable
    Public Sub SwitchOnAt(ByVal HourOn As Integer) Implements ITimeable.SwitchOn
        mHourOn = HourOn
        Console.WriteLine("Device comes on at {0}.00 hours", mHourOn)
    End Sub

    ' Implement the SwitchOff method from ITimeable
    Public Sub SwitchOffAt(ByVal HourOff As Integer) Implements ITimeable.SwitchOff
        mHourOff = HourOff
        Console.WriteLine("Device goes off at {0}.00 hours", mHourOff)
    End Sub

    ' Implement the IsOn property from ISwitchable and ITimeable
    Public ReadOnly Property IsOn() As Boolean _
        Implements ISwitchable.IsOn, ITimeable.IsOn

        Get
            Dim Now As Integer = DateTime.Now.Hour
            If (mAlwaysOn) Or (Now >= mHourOn And Now < mHourOff) Then
                Return True
            Else
                Return False
            End If
        End Get

    End Property

End Class

' ---------------------------------------------------------------------
' Define a class that contains the Main subroutine for this application
' ---------------------------------------------------------------------
Public Class MyApp

    ' Entry point for this application
    Shared Sub Main()

        ' Create a TimerSwitch, and pass it to UseTimerSwitch
        Dim timerSwitch1 As New TimerSwitch()
        UseTimerSwitch(timerSwitch1)

        ' Create a TimerSwitch, and pass it to UseSwitchable
        Dim timerSwitch2 As New TimerSwitch()
        UseSwitchable(timerSwitch2)

        ' Create a TimerSwitch, and pass it to UseTimeable
        Dim timerSwitch3 As New TimerSwitch()
        UseTimeable(timerSwitch3)

    End Sub

    ' This method specifically takes a TimerSwitch object
    Shared Sub UseTimerSwitch(ByVal aTimerSwitch As TimerSwitch)

        Console.WriteLine("Using a TimerSwitch object")

        ' Use TimerSwitch methods that implement the ISwitchable interface
        aTimerSwitch.SwitchOnConstant()
        aTimerSwitch.SwitchOffConstant()

        ' Use TimerSwitch methods that implement the ITimeable interface
        aTimerSwitch.SwitchOnAt(6)
        aTimerSwitch.SwitchOffAt(22)

        ' Use the IsOn property, which is defined in both interfaces
        Console.WriteLine("IsOn property: {0}" & vbCrLf, aTimerSwitch.IsOn)

    End Sub

    ' This method takes any kind of object that implements ISwitchable
    Shared Sub UseSwitchable(ByVal aSwitchable As ISwitchable)

        ' We must use the member names defined in ISwitchable
        Console.WriteLine("Using an object that implements ISwitchable")
        aSwitchable.SwitchOn()
        aSwitchable.SwitchOff()
        Console.WriteLine("IsOn property: {0}" & vbCrLf, aSwitchable.IsOn)

    End Sub

    ' This method takes any kind of object that implements ITimeable
    Shared Sub UseTimeable(ByVal aTimeable As ITimeable)

        ' We must use the member names defined in ITimeable
        Console.WriteLine("Using an object that implements ITimeable")
        aTimeable.SwitchOn(9)
        aTimeable.SwitchOn(11)
        Console.WriteLine("IsOn property: {0}" & vbCrLf, aTimeable.IsOn)

    End Sub

End Class
