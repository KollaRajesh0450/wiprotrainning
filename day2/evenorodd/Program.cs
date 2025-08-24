using System;

public class EvenOrOdd {
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"The number {num} is even");
        }
        else {
            Console.WriteLine($"The number {num} is odd");
        }
    }
}

