using System;
class Program
{
    static void Main()
    {
        bool validUsername = true;
        bool validPassword = false;

        if (validUsername && validPassword)
        {
            Console.WriteLine("Access Granted");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }

        Console.WriteLine("At least one valid ? " + (validUsername || validPassword));
        Console.WriteLine("Opposite of Username check = " + (!validUsername));
    }
}
