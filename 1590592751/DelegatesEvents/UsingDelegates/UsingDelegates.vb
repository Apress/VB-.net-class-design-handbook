Imports System
Imports System.Windows.Forms
Imports System.Drawing

Public Class Form1
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
    Friend WithEvents btnEllipse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents btnRectangle As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtTop As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnEllipse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEllipse
        '
        Me.btnEllipse.Location = New System.Drawing.Point(177, 282)
        Me.btnEllipse.Name = "btnEllipse"
        Me.btnEllipse.Size = New System.Drawing.Size(97, 24)
        Me.btnEllipse.TabIndex = 10
        Me.btnEllipse.Text = "Draw Ellipse"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Left"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(104, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Top"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(104, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Height"
        '
        'txtLeft
        '
        Me.txtLeft.Location = New System.Drawing.Point(46, 209)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(43, 20)
        Me.txtLeft.TabIndex = 1
        Me.txtLeft.Text = ""
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(46, 240)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(43, 20)
        Me.txtWidth.TabIndex = 5
        Me.txtWidth.Text = ""
        '
        'txtTop
        '
        Me.txtTop.Location = New System.Drawing.Point(141, 209)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(43, 20)
        Me.txtTop.TabIndex = 3
        Me.txtTop.Text = ""
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(141, 240)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(43, 20)
        Me.txtHeight.TabIndex = 7
        Me.txtHeight.Text = ""
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(72, 282)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(94, 24)
        Me.btnRectangle.TabIndex = 9
        Me.btnRectangle.Text = "Draw Rectangle"
        '
        'btnColor
        '
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.Location = New System.Drawing.Point(204, 209)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(70, 52)
        Me.btnColor.TabIndex = 8
        Me.btnColor.Text = "Color"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(286, 319)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnColor, Me.btnRectangle, Me.txtHeight, Me.txtTop, Me.txtWidth, Me.txtLeft, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.btnEllipse})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Delegates example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' ----------------------------------------------------------------
    ' Declare a Rectangle field, to indicate available drawing area
    ' ----------------------------------------------------------------
    Private mRect As Rectangle

    ' ----------------------------------------------------------------
    ' When the form loads, paint the available drawing area
    ' ----------------------------------------------------------------
    Private Sub Form1_Load(ByVal sender As Object, _
                           ByVal e As PaintEventArgs) _
                        Handles MyBase.Paint

        mRect = New Rectangle(0, 0, CInt(Width), CInt(Height / 2))
        e.Graphics.FillRectangle(New SolidBrush(Color.White), mRect)

    End Sub

    ' ----------------------------------------------------------------
    ' Handle the Click event for the btnColor button
    ' ----------------------------------------------------------------
    Private Sub btnColor_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                        Handles btnColor.Click

        Dim dlgColor As New ColorDialog()
        dlgColor.ShowDialog(Me)
        btnColor.BackColor = dlgColor.Color

    End Sub

    ' ----------------------------------------------------------------------
    ' Define a Delegate type, to indicate signature of method to call
    ' ----------------------------------------------------------------------
    Delegate Sub MyDelegate(ByVal aBrush As Brush, _
                            ByVal aRect As Rectangle)

    ' ----------------------------------------------------------------
    ' Handle the Click event for the btnRectangle button
    ' ----------------------------------------------------------------
    Private Sub btnRectangle_Click(ByVal sender As System.Object, _
                                   ByVal e As System.EventArgs) _
                        Handles btnRectangle.Click

        ' Create a Graphics object (we need its FillRectangle method)
        Dim aGraphics As Graphics = CreateGraphics()

        ' Declare a MyDelegate variable
        Dim aDelegate As MyDelegate

        ' Create a delegate object, and bind to the FillRectangle method
        aDelegate = New MyDelegate(AddressOf aGraphics.FillRectangle)

        ' Call MyDrawShape, and pass the delegate as a parameter
        MyDrawShape(aDelegate)

    End Sub

    ' ----------------------------------------------------------------------
    ' Handle the Click event for the btnEllipse button
    ' ----------------------------------------------------------------------
    Private Sub btnEllipse_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) _
                        Handles btnEllipse.Click

        ' Call MyDrawShape, with delegate bound to FillEllipse 
        Dim aGraphics As Graphics = CreateGraphics()
        MyDrawShape(AddressOf aGraphics.FillEllipse)

    End Sub



    ' ----------------------------------------------------------------------
    ' MyDrawShape uses a delegate to indicate which method to call
    ' ----------------------------------------------------------------------
    Public Sub MyDrawShape(ByVal theDelegate As MyDelegate)

        ' Are any text fields blank?
        If txtLeft.Text.Length = 0 Or txtTop.Text.Length = 0 Or _
           txtWidth.Text.Length = 0 Or txtHeight.Text.Length = 0 Then

            ' Display an error message, and return immediately 
            MessageBox.Show("Please fill in all text boxes", _
                            "Error", _
                             MessageBoxButtons.OK, _
                             MessageBoxIcon.Error)
            Return

        End If

        ' Get the coordinate values entered in the text fields
        Dim aRect As New Rectangle(Integer.Parse(txtLeft.Text), _
                                   Integer.Parse(txtTop.Text), _
                                   Integer.Parse(txtWidth.Text), _
                                   Integer.Parse(txtHeight.Text))

        ' Make sure the coordinates are in range
        If mRect.Contains(aRect) Then

            ' Get the color of the btnColor button
            Dim aBrush As New SolidBrush(btnColor.BackColor)

            ' Invoke the delegate, to draw the specified shape
            theDelegate.Invoke(aBrush, aRect)

        Else

            ' Display error message, and return immediately 
            MessageBox.Show("Coordinates are outside drawing area", _
                            "Error", _
                             MessageBoxButtons.OK, _
                             MessageBoxIcon.Error)

        End If

    End Sub

End Class
