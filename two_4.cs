using System;
class Program
{
    static void Main()
    {
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
    }
}
