using System;
class Program1
{
    static void Main()
    {
        // one_1
        Console.WriteLine("one_1:");
        float temp1 = 36.6f;
        if (temp1 > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");

        //one_2
        Console.WriteLine("\none_2");
        int age1 = 18; 
        if (age1 >= 18)
            Console.WriteLine("Eligible to Vote");
        else
            Console.WriteLine("Not Eligible");

        // one_3
        Console.WriteLine("\none_3");
        char gender1 = 'M';
        if (gender1 == 'M')
            Console.WriteLine("Male");
        else if (gender1 == 'F')
            Console.WriteLine("Female");
        else
            Console.WriteLine("Other");

        // one_4
        Console.WriteLine("\none_4");
        double price = 1000.0;
        double disPercent = 10.0;
        double disAmt = (price * disPercent) / 100.0;
        double final = price - disAmt;
        Console.WriteLine("Final Price = " + final);

        //one_5
        Console.WriteLine("\none_5");
        bool login = true;
        if (login)
            Console.WriteLine("Login successful");
        else
            Console.WriteLine("Access denied");

        //one_6
        Console.WriteLine("\none_6");
        int age2 = 25;
        float temp2 = 98.6f;
        char grade = 'A';
        bool pass = true;

        Console.WriteLine(age2 + " - " + age2.GetType());
        Console.WriteLine(temp2 + " - " + temp2.GetType());
        Console.WriteLine(grade + " - " + grade.GetType());
        Console.WriteLine(pass + " - " + pass.GetType());

        Console.WriteLine("------------------------------------------------------------------------------");
    }
}
