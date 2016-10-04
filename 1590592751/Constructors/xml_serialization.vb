Public Class Point
  Private MX As Integer
  Private MY As Integer

  Public Property X as Integer
    Get
      Return MX
    End Get

    Set(Value As Integer)
      MX = Value
    End Set
  End Property 

  Public Property Y as Integer
    Get
      Return MY
    End Get

    Set(Value As Integer)
      MY = Value 
    End Set
  End Property
 
  Public Overrides Function ToString() As String
    Return "(" & MX & "," & MY & ")"
  End Function 
End Class

Module XMLSerialization
  Sub Main()
    Dim P1 As New Point()
    P1.X = 6
    P1.Y = 4
    SaveToFile(P1)

    Dim P2 As Point = RetrieveFromFile()
    Console.WriteLine(P2.ToString())
  End Sub

  Sub SaveToFile(P as Point)
    Dim Serializer As New XmlSerializer(GetType(Point))
    Dim Writer As StreamWriter = New StreamWriter("point.xml") 
    Serializer.Serialize(Writer, P) 
  End Sub

  Function RetrieveFromFile() As Point
    Dim ReturnObject As Point
    Dim Serializer As New XmlSerializer(GetType(Point)) 
    Dim FS As FileStream = New FileStream("point.xml", _
      FileMode.Open) 

    ReturnObject = CType(Serializer.Deserialize(FS), Point) 
    FS.Close()
    Return ReturnObject
  End Function
End Module
