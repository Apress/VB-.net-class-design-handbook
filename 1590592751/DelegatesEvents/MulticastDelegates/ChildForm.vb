Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing

Public Class ChildForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'ChildForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(176, 101)
        Me.Name = "ChildForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual

    End Sub

#End Region

    ' ----------------------------------------------------------------
    ' Handle the Load event for this form
    ' ----------------------------------------------------------------
    Private Sub ChildForm_Load(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                    Handles MyBase.Load

        ' Display the date-and-time of creation, in the caption bar
        Me.Text = "Created " & DateTime.Now.ToLongTimeString()

    End Sub

    ' ----------------------------------------------------------------
    ' This method will be called via multicast delegate in main form
    ' ----------------------------------------------------------------
    Public Function Repaint(ByVal theColor As Color) As String

        ' Set the color for this form, and update the caption bar
        Me.BackColor = theColor
        Me.Text = "Updated " & DateTime.Now.ToLongTimeString()
        Return Me.Text

    End Function

    ' ----------------------------------------------------------------
    ' Handle the Cancel event for this form
    ' ----------------------------------------------------------------
    Protected Sub ChildForm_Cancel(ByVal sender As System.Object, _
                                   ByVal e As CancelEventArgs) _
                    Handles MyBase.Closing

        ' Tell the main form we are closing, so the main form can 
        ' remove us from its multicast delegate
        Dim MyOwner As MainForm = CType(Me.Owner, MainForm)
        MyOwner.ChildFormClosing(Me)

    End Sub

End Class
