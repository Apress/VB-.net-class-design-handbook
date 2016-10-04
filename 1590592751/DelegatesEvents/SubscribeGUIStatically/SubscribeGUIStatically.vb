Imports System
Imports System.Windows.Forms

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
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDebit As System.Windows.Forms.Button
    Friend WithEvents btnCredit As System.Windows.Forms.Button
    Friend WithEvents sbStatus As System.Windows.Forms.StatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDebit = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.sbStatus = New System.Windows.Forms.StatusBar()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(50, 15)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(64, 20)
        Me.txtAmount.TabIndex = 0
        Me.txtAmount.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Amount"
        '
        'btnDebit
        '
        Me.btnDebit.Location = New System.Drawing.Point(141, 14)
        Me.btnDebit.Name = "btnDebit"
        Me.btnDebit.Size = New System.Drawing.Size(70, 24)
        Me.btnDebit.TabIndex = 2
        Me.btnDebit.Text = "Debit"
        '
        'btnCredit
        '
        Me.btnCredit.Location = New System.Drawing.Point(141, 44)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(70, 24)
        Me.btnCredit.TabIndex = 3
        Me.btnCredit.Text = "Credit"
        '
        'sbStatus
        '
        Me.sbStatus.Location = New System.Drawing.Point(0, 87)
        Me.sbStatus.Name = "sbStatus"
        Me.sbStatus.Size = New System.Drawing.Size(229, 22)
        Me.sbStatus.SizingGrip = False
        Me.sbStatus.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(229, 109)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.sbStatus, Me.btnCredit, Me.btnDebit, Me.txtAmount, Me.Label1})
        Me.Name = "Form1"
        Me.Text = "Account form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Handle the Click event on btnDebit
    Private Sub btnDebit_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                    Handles btnDebit.Click

        MessageBox.Show("Debit $" & CInt(txtAmount.Text), _
                        "Click event handler for btnDebit")

    End Sub

    ' Handle the Click event on btnCredit
    Private Sub btnCredit_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
                    Handles btnCredit.Click

        MessageBox.Show("Credit $" & CInt(txtAmount.Text), _
                        "Click event handler for btnCredit")

    End Sub

    ' Handle the Click event on btnDebit and btnCredit
    Private Sub btnAny_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                    Handles btnDebit.Click, btnCredit.Click

        If TypeOf sender Is Button Then

            Dim theButton As Button = CType(sender, Button)

            sbStatus.Text = "Clicked " & theButton.Text & _
                            ", amount $" & txtAmount.Text


        End If

    End Sub


End Class
