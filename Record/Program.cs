internal class Program
{
    private static void Main(string[] args)
    {
       var p1 = new Point(1, 2);
        var p2 = new Point(1, 2);
        Console.WriteLine(p1);
            Console.WriteLine(p2);

        Console.WriteLine(p1.GetHashCode());
        Console.WriteLine(p2.GetHashCode());
        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p2 != p1);
    }

    record Point(int x, int y);
}