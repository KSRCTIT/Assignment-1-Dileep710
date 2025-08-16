using System;
class Program
{
    static void Main()
    {
        double price = 1000.0;
        double discountPercent = 10.0;

        double discountAmount = (price * discountPercent) / 100;
        double finalPrice = price - discountAmount;

        Console.WriteLine("Final Price = " + finalPrice);
    }
}
