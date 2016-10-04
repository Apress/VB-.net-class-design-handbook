Imports System
Imports System.Windows.Forms

Namespace SimpleWindowsApplication
  Public Class Form1
    Inherits System.Windows.Forms.Form

    Private Components As System.ComponentModel.IContainer

    Public Sub New()
      MyBase.New()
      InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose( _
                                  ByVal Disposing As Boolean)
      If Disposing Then
        If Not (Components Is Nothing) Then
          Components.Dispose()
        End If
      End If
      MyBase.Dispose(Disposing)
    End Sub

    Private Sub InitializeComponent()
        Components = New System.ComponentModel.Container()
        Me.Text = "Form1"
    End Sub

    Shared Public Sub Main()
      Application.Run(New Form1())
    End Sub
  End Class
End Namespace
