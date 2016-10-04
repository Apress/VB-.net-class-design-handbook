Interface IConnectable

   Function Connect() As Boolean
   Sub Disconnect()

End Interface

Interface ITimedConnectable 
   Inherits IConnectable

   Sub Timeout(ByVal millisecs As Long)

End Interface

Class MessageQueue
   Implements ITimedConnectable
   Implements IDisposable

   ' Implement Connect method from ITimedConnectable
   Public Function Connect() As Boolean _
      Implements ITimedConnectable.Connect

      ' Implementation code to connect

   End Function

   ' Implement the Disconnect method 
   Public Sub Disconnect() _
      Implements ITimedConnectable.Disconnect 
      
      ' Implementation code to disconnect 

   End Sub

   ' Implement the Timeout method
   Public Sub Timeout(ByVal millisecs As Long) _
      Implements ITimedConnectable.Timeout

      ' Implementation code to specify a timeout

   End Sub

   ' Implement the Dispose method from IDisposable
   Public Sub Dispose() _
      Implements IDisposable.Dispose

      ' Implementation code to dispose object

   End Sub

   ' Additional method needed by MessageQueue
   Public Sub SendMessage(ByVal msg As String)

      Console.WriteLine("Sending message: {0}", msg)

   End Sub

End Class
