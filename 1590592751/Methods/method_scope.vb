Public Class Train

  Protected Sub StopTrain() 
    ApplyBrakes()
    StopEngine()
  End Sub

  Private Sub StartEngine()
  End Sub

  Private Sub StopEngine()
  End Sub

  Private Sub ReleaseBrakes()
  End Sub

  Protected Friend Sub ApplyBrakes()
  End Sub

End Class

Public Class PassengerTrain
  Inherits Train
  
  Friend Sub StopAtStation()
    StopTrain() 
    UnlockDoors()
  End Sub
  
  Private Sub UnlockDoors()
  End Sub
  
  Public Sub OpenDoors()
  End Sub
  
  Public Sub PullEmergencyCord()
    Mybase.ApplyBrakes()
  End Sub

End Class
