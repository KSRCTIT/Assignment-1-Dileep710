using System;
class Program
{
    static void Main()
    {
        int correctPin = 1234;
        int tries = 0;

        while (tries < 3)
        {
            Console.Write("Enter PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            if (pin == correctPin)
            {
                Console.WriteLine("Access Granted");
                return;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                tries++;
            }
        }

        Console.WriteLine("Card Blocked");
    }
}
