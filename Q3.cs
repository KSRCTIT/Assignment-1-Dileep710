using System;
class Program3
{
    static void Main()
    {
        Console.WriteLine("Question 3.");

        //three_1
        Console.WriteLine("three_1:");
        int correctPin = 1234;
        int attempts = 0;
        bool access = false;
        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin == correctPin)
            {
                Console.WriteLine("Access Granted");
                access = true;
                break; 
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                attempts++;
            }
        }
        if (!access)
        {
            Console.WriteLine("Card Blocked");
        }

        //three_2
        Console.WriteLine("\nthree_2:");
        char choice = 'Y';
        while (choice == 'Y' || choice == 'y')
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            Console.Write("Do you want another table? (Y/N): ");
            string inp = Console.ReadLine();
            if (string.IsNullOrEmpty(inp))
            {
                choice = 'N';
            }
            else
            {
                choice = inp[0];
            }
        }

        //three_2_B
        Console.WriteLine("\nthree_2_B:");
        Console.Write("Enter units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        int bill = 0;
        if (units <= 100)
        {
            bill = units * 2;
        }
        else if (units <= 200)
        {
            bill = (100 * 2) + ((units - 100) * 3);
        }
        else
        {
            bill = (100 * 2) + (100 * 3) + ((units - 200) * 5);
        }
        Console.WriteLine("Total Bill = Rs." + bill);

        //three_3
        Console.WriteLine("\nthree_3:");
        int sum = 0;
        Console.WriteLine("Enter marks of 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            int mark = Convert.ToInt32(Console.ReadLine());
            sum += mark;
        }
        double avg = sum / 5.0;
        Console.WriteLine("Average = " + avg);
        if (avg >= 40)
        {
            Console.WriteLine("Result: Passed");
        }
        else
        {
            Console.WriteLine("Result: Failed");
        }

        //three_4
        Console.WriteLine("\nthree_4:");
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        bool ok = true;
        foreach (char c in name)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                ok = false;
                break;
            }
        }
        if (ok)
        {
            Console.WriteLine("Valid Name");
        }
        else
        {
            Console.WriteLine("Invalid Name");
        }
    }
}
