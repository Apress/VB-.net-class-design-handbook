Imports System
Imports System.Windows.Forms
Imports System.Drawing

Public Class MainForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTop As System.Windows.Forms.TextBox
    Friend WithEvents btnAddWindow As System.Windows.Forms.Button
    Friend WithEvents btnColors As System.Windows.Forms.Button
    Friend WithEvents sbStatus As System.Windows.Forms.StatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.btnAddWindow = New System.Windows.Forms.Button()
        Me.btnColors = New System.Windows.Forms.Button()
        Me.sbStatus = New System.Windows.Forms.StatusBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Left"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(103, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Top"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(103, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Height"
        '
        'txtLeft
        '
        Me.txtLeft.Location = New System.Drawing.Point(47, 15)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(43, 20)
        Me.txtLeft.TabIndex = 1
        Me.txtLeft.Text = ""
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(47, 47)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(43, 20)
        Me.txtWidth.TabIndex = 5
        Me.txtWidth.Text = ""
        '
        'txtTop
        '
        Me.txtTop.Location = New System.Drawing.Point(141, 15)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(43, 20)
        Me.txtTop.TabIndex = 3
        Me.txtTop.Text = ""
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(141, 47)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(43, 20)
        Me.txtHeight.TabIndex = 7
        Me.txtHeight.Text = ""
        '
        'btnAddWindow
        '
        Me.btnAddWindow.Location = New System.Drawing.Point(214, 13)
        Me.btnAddWindow.Name = "btnAddWindow"
        Me.btnAddWindow.Size = New System.Drawing.Size(96, 24)
        Me.btnAddWindow.TabIndex = 8
        Me.btnAddWindow.Text = "Add Window"
        '
        'btnColors
        '
        Me.btnColors.Location = New System.Drawing.Point(214, 44)
        Me.btnColors.Name = "btnColors"
        Me.btnColors.Size = New System.Drawing.Size(96, 24)
        Me.btnColors.TabIndex = 9
        Me.btnColors.Text = "Change Colors"
        '
        'sbStatus
        '
        Me.sbStatus.Location = New System.Drawing.Point(0, 77)
        Me.sbStatus.Name = "sbStatus"
        Me.sbStatus.Size = New System.Drawing.Size(321, 22)
        Me.sbStatus.SizingGrip = False
        Me.sbStatus.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(321, 99)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.sbStatus, Me.btnColors, Me.btnAddWindow, Me.txtHeight, Me.txtTop, Me.txtWidth, Me.txtLeft, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multicast delegates example"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' ----------------------------------------------------------------
    ' Define a Delegate type
    ' ----------------------------------------------------------------
    Delegate Function MyDelegate(ByVal aColor As Color) As String

    ' ----------------------------------------------------------------
    ' Declare a MyDelegate field, to refer to the multicast delegate 
    ' ----------------------------------------------------------------
    Private mTheDelegate As MyDelegate

    ' ----------------------------------------------------------------
    ' Handle the Click event for the btnAddWindow button
    ' ----------------------------------------------------------------
    Private Sub btnAddWindow_Click(ByVal sender As System.Object, _
                                   ByVal e As System.EventArgs) _
                    Handles btnAddWindow.Click

        ' Are any text fields blank?
        If txtLeft.Text.Length = 0 Or txtTop.Text.Length = 0 Or _
           txtWidth.Text.Length = 0 Or txtHeight.Text.Length = 0 Then

            ' Display an error message, and return immediately 
            MessageBox.Show("Please fill in all text boxes.", _
                            "Error adding window", _
                             MessageBoxButtons.OK, _
                             MessageBoxIcon.Error)
            Return

        End If

        ' Create a new child form with the specified location and size
        Dim aChildForm As New ChildForm()
        aChildForm.Owner = Me
        aChildForm.DesktopBounds = New Rectangle( _
                                        Integer.Parse(txtLeft.Text), _
                                        Integer.Parse(txtTop.Text), _
                                        Integer.Parse(txtWidth.Text), _
                                        Integer.Parse(txtHeight.Text))
        aChildForm.Show()

        ' Create a new delegate for the child form's Repaint method
        Dim newDelegate As MyDelegate = AddressOf aChildForm.Repaint

        ' If multicast delegate is Nothing, this is the first child form
        If mTheDelegate Is Nothing Then

            ' Use new delegate as the basis for the multicast delegate
            mTheDelegate = newDelegate
            sbStatus.Text = "Created first child form."

        Else

            ' Combine new delegate into the multicast delegate
            mTheDelegate = System.Delegate.Combine(mTheDelegate, _
                                                   newDelegate)

            ' Use multicast delegate to count the child forms 
            sbStatus.Text = "Created child form " & _
                             mTheDelegate.GetInvocationList().Length & _
                            "."
        End If

    End Sub

    ' ----------------------------------------------------------------
    ' Handle the Click event for the btnColor button
    ' ----------------------------------------------------------------
    Private Sub btnColors_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
                    Handles btnColors.Click

        ' If multicast delegate is Nothing, there are no child forms
        If mTheDelegate Is Nothing Then

            MessageBox.Show("There are no child forms to change.", _
                            "Error changing color", _
                             MessageBoxButtons.OK, _
                             MessageBoxIcon.Error)

        Else

            ' Ask user to choose a color
            Dim dlgColor As New ColorDialog()
            dlgColor.ShowDialog()

            ' Invoke multicast delegate, to repaint all the child forms
            mTheDelegate.Invoke(dlgColor.Color)

            ' Use multicast delegate to count the child forms 
            sbStatus.Text = "Updated " & _
                             mTheDelegate.GetInvocationList().Length & _
                             " child form(s)."

        End If

    End Sub

    ' ----------------------------------------------------------------
    ' Child forms call this method, to tell us they are closing
    ' ----------------------------------------------------------------
    Public Sub ChildFormClosing(ByVal aChildForm As ChildForm)

        ' Create a delegate for the ChildForm that is closing
        Dim unneededDelegate As MyDelegate = AddressOf aChildForm.Repaint

        ' Remove the delegate from the multicast delegate
        mTheDelegate = System.Delegate.Remove(mTheDelegate, _
                                              unneededDelegate)

        ' If multicast delegate is Nothing, there are no child forms left
        If mTheDelegate Is Nothing Then

            sbStatus.Text = "Final child form has been closed."

        Else

            ' Use multicast delegate to count the child forms 
            sbStatus.Text = "Child form closed, " & _
                             mTheDelegate.GetInvocationList().Length & _
                             " form(s) remaining."

        End If

    End Sub

End Class
