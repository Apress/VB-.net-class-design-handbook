using PointClass;

class TestPoint
{
  public static void Main()
  {
    Point P1 = new Point(4, 4);
    Console.WriteLine(P1.ToString());
    Point P2 = new Point();
    Console.WriteLine(P2.ToString());
  }
}
