using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Begining:
            int number1 = 0; int number2 = 0;

            Console.WriteLine("Hello im your trusty Calcolator\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type a number then Enter");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number and press Enter");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Choose an option and watch the magic happen:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {number1} + {number2} (Insert Drum roll here)= " + (number1 + number2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {number1} - {number2} (Insert Drum roll here)= " + (number1 - number2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {number1} * {number2} (Insert Drum roll here)= " + (number1 * number2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {number1} / {number2} (Insert Drum roll here)= " + (number1 / number2));
                    break;
            }
            Console.WriteLine("Do you want more Number Magic");
            Console.WriteLine("\ty - Yes");
            Console.WriteLine("\tn - No");
            switch (Console.ReadLine())
            {
                case "y":
                    Console.Clear();
                    goto Begining;
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
            }

        }
    }
}