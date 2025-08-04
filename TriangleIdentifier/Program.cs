using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter side 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter side 3: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Triangle type: Equilateral");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Triangle type: Isosceles");
        else
            Console.WriteLine("Triangle type: Scalene");
    }
}
