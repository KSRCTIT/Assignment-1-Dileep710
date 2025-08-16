using System;
class Program
{
    static bool IsValidName(string name)
    {
        foreach(char c in name)
        {
            if (!char.IsLetter(c) && c != ' ')
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        if(IsValidName(name))
        {
            Console.WriteLine("Valid Name");
        }
        else{
            Console.WriteLine("Invalid Name");
        }
    }
}
