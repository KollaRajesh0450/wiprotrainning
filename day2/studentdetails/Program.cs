using System;

public class StudentDetails
{
    static void Main()
    {
        Console.WriteLine("What you need to do: \n 1.Add Student details \n 2.delete student details \n 3.view the student details \n 4.update the student details");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("students details entered successfull");
                break;
            case 2:
                Console.WriteLine("students details deleted successfull");
                break;
            case 3:
                Console.WriteLine("students details viewed successfull");
                break;
            case 4:
                Console.WriteLine("students details updated successfull");
                break;
            default:
                Console.WriteLine("please select the corrct option");
                break;
        }

    }
}