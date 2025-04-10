struct Point
{
    public int x;
    public int y;
}

class Program
{
    static void Main()
    {
        Point P1;
        Point P2;

        // Ask user for Point 1
        Console.WriteLine(" Enter x for Point 1: ");
        P1.x = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(" Enter y for Point 1: ");
        P1.y = Convert.ToInt32(Console.ReadLine());


        // Ask user for Point 2
        Console.WriteLine(" Enter x for Point 2: ");
        P2.x = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(" Enter y for Point 2: ");
        P2.y = Convert.ToInt32(Console.ReadLine());

        // Compare x values
        if (P1.x > P2.x)
        {
            Console.WriteLine("P2 is to the left of P1");

        }
        else if (P1.x < P2.x)
        {
            Console.WriteLine("P2 is to the right of P1");
        }
        else
        {
        }
    }
}
