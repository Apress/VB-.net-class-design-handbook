Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.VisualBasic

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
    Friend WithEvents txtNewAccountName As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAccount As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstUnlogged As System.Windows.Forms.ListBox
    Friend WithEvents lstLogged As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnUnlog As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEventLog As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewAccountName = New System.Windows.Forms.TextBox()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstUnlogged = New System.Windows.Forms.ListBox()
        Me.lstLogged = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnUnlog = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEventLog = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New account name:"
        '
        'txtNewAccountName
        '
        Me.txtNewAccountName.Location = New System.Drawing.Point(16, 32)
        Me.txtNewAccountName.Name = "txtNewAccountName"
        Me.txtNewAccountName.Size = New System.Drawing.Size(128, 20)
        Me.txtNewAccountName.TabIndex = 1
        Me.txtNewAccountName.Text = ""
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(152, 30)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(88, 24)
        Me.btnAddAccount.TabIndex = 2
        Me.btnAddAccount.Text = "Add Account"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unlogged accounts"
        '
        'lstUnlogged
        '
        Me.lstUnlogged.Location = New System.Drawing.Point(16, 96)
        Me.lstUnlogged.Name = "lstUnlogged"
        Me.lstUnlogged.Size = New System.Drawing.Size(144, 95)
        Me.lstUnlogged.TabIndex = 4
        '
        'lstLogged
        '
        Me.lstLogged.Location = New System.Drawing.Point(248, 96)
        Me.lstLogged.Name = "lstLogged"
        Me.lstLogged.Size = New System.Drawing.Size(144, 95)
        Me.lstLogged.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(248, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Logged accounts"
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(172, 104)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(64, 24)
        Me.btnLog.TabIndex = 5
        Me.btnLog.Text = "Log  >>"
        '
        'btnUnlog
        '
        Me.btnUnlog.Location = New System.Drawing.Point(172, 136)
        Me.btnUnlog.Name = "btnUnlog"
        Me.btnUnlog.Size = New System.Drawing.Size(64, 24)
        Me.btnUnlog.TabIndex = 6
        Me.btnUnlog.Text = "<<  Unlog"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Event log"
        '
        'txtEventLog
        '
        Me.txtEventLog.BackColor = System.Drawing.Color.White
        Me.txtEventLog.Location = New System.Drawing.Point(16, 224)
        Me.txtEventLog.Name = "txtEventLog"
        Me.txtEventLog.ReadOnly = True
        Me.txtEventLog.Size = New System.Drawing.Size(376, 264)
        Me.txtEventLog.TabIndex = 10
        Me.txtEventLog.Text = ""
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnAddAccount
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEventLog, Me.Label4, Me.btnUnlog, Me.btnLog, Me.Label3, Me.lstLogged, Me.lstUnlogged, Me.Label2, Me.btnAddAccount, Me.txtNewAccountName, Me.Label1})
        Me.Name = "MainForm"
        Me.Text = "Main form"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Create a new BankAccount, and display it in a BankAccountForm
    Private Sub btnAddAccount_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) _
                        Handles btnAddAccount.Click

        ' Create a new BankAccount object
        Dim anAccount As New BankAccount(txtNewAccountName.Text, 0.0)

        ' Display BankAccount object in the 'unlogged' list box
        lstUnlogged.Items.Add(anAccount)

        ' Reset focus to text box, and clear it ready for next account
        txtNewAccountName.Text = ""
        txtNewAccountName.Focus()

        ' Create new BankAccountForm, to display BankAccount object
        Dim aBankAccountForm As New BankAccountForm()
        aBankAccountForm.Account = anAccount
        aBankAccountForm.Show()

    End Sub

    ' Dynamically add event handlers for the selected account
    Private Sub btnLog_Click(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) _
                    Handles btnLog.Click

        ' Get selected item in 'unlogged' list box
        Dim Selected As Object = lstUnlogged.SelectedItem

        ' Make sure the user has selected an item!
        If Selected Is Nothing Then

            MessageBox.Show("Please select an account to log.", _
                            "Error logging account", _
                             MessageBoxButtons.OK, _
                             MessageBoxIcon.Error)
        Else

            ' Downcast selected item to the BankAccount type
            Dim Acc As BankAccount = CType(Selected, BankAccount)

            ' Add handlers for all events on this BankAccount object
            AddHandler Acc.Overdrawn, _
                       AddressOf Me.BankAccount_Overdrawn

            AddHandler Acc.LargeDeposit, _
                       AddressOf Me.BankAccount_LargeDeposit

            ' Move account to the 'logged' list box
            lstLogged.Items.Add(Selected)
            lstUnlogged.Items.Remove(Selected)

        End If

    End Sub

    ' Dynamically remove event handlers for the selected account
    Private Sub btnUnlog_Click(ByVal sender As System.Object, _
                               ByVal e As System.EventArgs) _
                    Handles btnUnlog.Click

        ' Get selected item in 'logged' list box
        Dim Selected As Object = lstLogged.SelectedItem

        ' Make sure the user has selected an item!
        If Selected Is Nothing Then

            MessageBox.Show("Please select an account to unlog.", _
                            "Error unlogging account", _
                             MessageBoxButtons.OK, _
                             MessageBoxIcon.Error)
        Else

            ' Downcast selected item to the BankAccount type
            Dim Acc As BankAccount = CType(Selected, BankAccount)

            ' Remove handlers for all events on this BankAccount object
            RemoveHandler Acc.Overdrawn, _
                          AddressOf Me.BankAccount_Overdrawn

            RemoveHandler Acc.LargeDeposit, _
                          AddressOf Me.BankAccount_LargeDeposit

            ' Move account to the 'unlogged' list box
            lstUnlogged.Items.Add(Selected)
            lstLogged.Items.Remove(Selected)

        End If

    End Sub

    ' Handle Overdrawn event from any BankAccount 
    Public Sub BankAccount_Overdrawn(ByVal sender As BankAccount, _
                                     ByVal args As BankAccountEventArgs)

        Me.txtEventLog.AppendText( _
                "Overdrawn event at " & args.TimeStamp & vbCrLf & _
                vbTab & "Account holder: " & args.AccountHolder & vbCrLf & _
                vbTab & "Amount of transaction: " & args.Amount & vbCrLf & _
                vbTab & "Current balance: " & sender.Balance & _
                vbCrLf & vbCrLf)

    End Sub

    ' Handle LargeDeposit event from any BankAccount 
    Public Sub BankAccount_LargeDeposit(ByVal sender As BankAccount, _
                                        ByVal args As BankAccountEventArgs)

        Me.txtEventLog.AppendText( _
                "LargeDeposit event at " & args.TimeStamp & vbCrLf & _
                vbTab & "Account holder: " & args.AccountHolder & vbCrLf & _
                vbTab & "Amount of transaction: " & args.Amount & vbCrLf & _
                vbTab & "Current balance: " & sender.Balance & _
                vbCrLf & vbCrLf)

    End Sub

End Class
