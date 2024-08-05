internal class Program
{
    private static void Main(string[] args)
    {
       var p1 = new Point(1, 2);
       var p2 = new Point(1, 2);
        //p1 = p2;
        Console.WriteLine("is p1 = p2 "+ p1.Equals(p2));
       
        Console.WriteLine("is p1 = p2 " + Object.ReferenceEquals(p1,p2));

        Console.WriteLine($"p1 Hash :{p1.GetHashCode()}");
        Console.WriteLine($"p2 Hash :{p2.GetHashCode()}");

    }

    class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    } 
}