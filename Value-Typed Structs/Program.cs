internal class Program
{
    private static void Main(string[] args)
    {
        var p1 = new point(7, 8);
        var p2 = new point(7, 8);
        Console.WriteLine($"is p1 = p2 : {p1.Equals(p2)}");
        
        Console.WriteLine($"is p1 points to p2 : {Object.ReferenceEquals(p1,p2)}");

        Console.WriteLine($"p1 Hash :{p1.GetHashCode()}" );
        Console.WriteLine($"p2 Hash :{p2.GetHashCode()}");


    }

    struct point
    {

        int x;
        int y;

        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}