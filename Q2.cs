using System;
class Program2
{
    static void Main()
    {
        Console.WriteLine("Question 2");

        //two_1
        Console.WriteLine("two_1:");
        int a = 10, b = 5;
        Console.WriteLine("Total apples = " + (a + b));
        Console.WriteLine("Difference of pencils = " + (a - b));
        Console.WriteLine("Total pages copied = " + (a * b));
        Console.WriteLine("Chocolates per kid = " + (a / b));
        Console.WriteLine("Leftover candies = " + (a % b));

        //two_2
        Console.WriteLine("\ntwo_2:");
        int player_A = 20, player_B = 15;
        Console.WriteLine("Player A > Player B ? " + (player_A > player_B));
        Console.WriteLine("Scores equal ? " + (player_A == player_B));
        Console.WriteLine("Any player failed to beat other ? " + (player_A <= player_B || player_B <= player_A));

        //two_3
        Console.WriteLine("\ntwo_3:");
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

        //two_4
        Console.WriteLine("\ntwo_4:");
        int score = 50;
        Console.WriteLine("Initial Score = " + score);
        score = score + 10;
        Console.WriteLine("After correct answer = " + score);
        score = score - 5;
        Console.WriteLine("After wrong answer = " + score);
        score = score * 2;
        Console.WriteLine("After bonus round = " + score);
        score = score / 5;
        Console.WriteLine("After penalty = " + score);

        //two_5
        Console.WriteLine("\ntwo_5:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter age of person " + i + ": ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eligible to Vote");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }Console.WriteLine("------------------------------------------------------------------------------------");
    }
}
