using System;

public class Program
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int swap;
        if (x < z)
        {
            swap = x;
            x = z;
            z = swap;
        }
        if (x < y)
        {
            swap = x;
            x = y;
            y = swap;
        }

        if (y < z)
        {
            swap = y;
            y = z;
            z = swap;
        }

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}