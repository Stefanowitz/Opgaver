using System;

namespace Calculator
{
    class Program
    {
        public static MainMenu mm = new MainMenu();

        static void Main(string[] args)
        {
            mm.Menu();
        }
    }

    class MainMenu
    {
        public static Cal calc = new Cal();
        public static Distance dis = new Distance();
        public void Menu()
        {

            Console.WriteLine("Hello there how can i be of service");
            Console.WriteLine("\t1 - Normal Calculator");
            Console.WriteLine("\t2 - Distance Converter");
            //Console.WriteLine("\t3 - Weight Converter");
            //Console.WriteLine("\t2 - Height COnverter");
            Console.WriteLine("Please choose an option");
            switch (Console.ReadLine())
            {
                case "1":
                    calc.CalBegin();
                    break;
                case "2":
                    dis.DisBegin();
                    break;
            }
        }
    }

    class Cal
    {
        public static MainMenu mm = new MainMenu();


        int number1 = 0; int number2 = 0;
        public void CalBegin()
        {
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
            Math();

            MoreMathMagic();
        }
        public void Math()
        {

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
        }

        public void MoreMathMagic()
        {
            Console.WriteLine("Do you want to restart or go back to Main Menu");
            Console.WriteLine("\tr - Restart");
            Console.WriteLine("\tm - Menu");
            switch (Console.ReadLine())
            {
                case "r":
                    Console.Clear();
                    CalBegin();
                    break;
                case "m":
                    mm.Menu();
                    break;
            }
        }
    }


    class Distance
    {
        public static MainMenu mm = new MainMenu();


        int lenght = 0;
        public void DisBegin()
        {
            Console.Clear();
            Console.WriteLine("Let's Start with somthing simple What is the lenght");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now you have to pick how i shall Convert it");
            Console.WriteLine("\t1 - KM to Miles");
            Console.WriteLine("\t2 - Miles to KM");
            DisMath();


        }

        double mileUnitLenght = 0.62137;
        double kmUnitLenght = 1.609344;
        public void DisMath()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"\nHow do we do this");
                    Console.WriteLine($"\nI know That 1 km is equivalent to {mileUnitLenght}");
                    Console.WriteLine($"\nBut we need to find what {lenght} is in mile(s)");
                    Console.WriteLine($"\nLet's do this {lenght} * {mileUnitLenght}");
                    Console.WriteLine((lenght * mileUnitLenght) + " mile(s)");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"\nHow do we do this");
                    Console.WriteLine($"\nI know That 1 mile is equivalent to {kmUnitLenght}");
                    Console.WriteLine($"\nBut we need to find what {lenght} is in km");
                    Console.WriteLine($"\nLet's do this {lenght} * {kmUnitLenght}");
                    Console.WriteLine((lenght * kmUnitLenght) + " km");
                    break;

            }
        }

        public void Restart()
        {
            Console.WriteLine("Do you want to restart or go back to Main Menu");
            Console.WriteLine("\tr - Restart");
            Console.WriteLine("\tm - Menu");
            switch (Console.ReadLine())
            {
                case "r":
                    Console.Clear();
                    DisBegin();
                    break;
                case "m":
                    mm.Menu();
                    break;
            }
        }
    }
}
