Imports System
Imports System.Collections
Imports System.Text

Public Class Node

  Private Shared rootNode As Node

  Shared Sub New()
    rootNode = New Node(Nothing, "Root")
  End Sub

  Private parentNode As Node
  Private nodeName As String
  Private children As IList

  Private Sub New(parent As Node, name As String)
    Me.parentNode = parent
    Me.nodeName = name
    Me.children = New ArrayList()
    If Not (parentNode Is Nothing) Then parentNode.AddChild(Me)
  End Sub

  Public Shared ReadOnly Property Root As Node
    Get
      Return rootNode
    End Get
  End Property

  Public ReadOnly Property Parent As Node
    Get
      Return parentNode
    End Get
  End Property

  Public ReadOnly Property Name As String
    Get
      Return nodeName
    End Get
  End Property

  Public Function CreateChild(name As String) As Node
    Return New Node(Me, name)
  End Function

  Private Function AddChild(child As Node)
    children.Add(child)
  End Function

  Public Default ReadOnly Property Child(i As Integer) As Node
    Get
      Return children(i)
    End Get
  End Property

  Public ReadOnly Property CountOfChildren As Integer
    Get
      Return children.Count
    End Get
  End Property

  Public Overrides Function ToString() As String
    Dim sb As New StringBuilder()
    sb.Append("<")
    sb.Append(nodeName)
    sb.Append(">")
    Dim c As Node
    For Each c In children
      sb.Append(c.toString())
    Next
    sb.Append("</")
    sb.Append(nodeName)
    sb.Append(">")
    Return sb.ToString()
  End Function

End Class

Public Module MainModule
  Public Sub Main()
    Node.Root.CreateChild("Child1")
    Node.Root.CreateChild("Child2")
    Node.Root(1).CreateChild("Child3")

    Console.WriteLine(Node.Root)
  End Sub
End Module
