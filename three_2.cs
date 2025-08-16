using System;
class Program
{
    static void Main()
    {
        char choice = 'Y';
        while (choice == 'Y' || choice == 'y')
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            Console.Write("Do you want another table? (Y/N): ");
            choice = Convert.ToChar(Console.ReadLine());
        }
    }
}
