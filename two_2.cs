using System;
class Program
{
    static void Main()
    {
        int playerA = 20;
        int playerB = 15;

        Console.WriteLine("Player A > Player B ? " + (playerA > playerB));
        Console.WriteLine("Scores equal ? " + (playerA == playerB));
        Console.WriteLine("Any player failed to beat other ? " + (playerA <= playerB || playerB <= playerA));
    }
}
