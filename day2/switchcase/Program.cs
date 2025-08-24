using System;

public class First{
    static void Main(){
        Console.WriteLine("Select the option \n 1.Check for prime or not \n 2.check for odd or not \n 3.check for even or not");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                break;
            case 2:
                Console.WriteLine("Enter the number for check odd or not?");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine($"Number {number} is Odd");
                }
                else
                {
                    Console.WriteLine($"Number {number} is not a odd number");
                }
                break;
            case 3:
                Console.WriteLine("Enter the number for check Even or not?");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Number {num} is Even");
                }
                else
                {
                    Console.WriteLine($"Number {num} is not a Even number");
                }
                break;
        }
    }
}