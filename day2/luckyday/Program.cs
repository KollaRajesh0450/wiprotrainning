using System;

public class Luckyday
{
    static void Main()
    {
        Console.WriteLine("Please Enter your Lucky day :");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Moday is your lucky day");
                break;
            case 2:
                Console.WriteLine("tuesday is your lucky day");
                break;
            case 3:
                Console.WriteLine("wednesday is your lucky day");
                break;
            case 4:
                Console.WriteLine("thurday is your lucky day");
                break;
            case 5:
                Console.WriteLine("friday is your lucky day");
                break;
            case 6:
                Console.WriteLine("saturday is your lucky day");
                break;
            case 7:
                Console.WriteLine("Sunday is your lucky day");
                break;
            default:
                Console.WriteLine("All days are lucky");
                break;

        }
    }
}