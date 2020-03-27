using System;
using System.Collections.Generic;
using System.Text;

namespace Calcolator
{
    class Heat
    {
        public static MainMenu mm = new MainMenu();

        int heat = 0;
        public void HeatBegin()
        {
            Console.Clear();
            Console.WriteLine("Okay Weight Let's Begin, What is the Hot is it");
            heat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now you have to pick how i shall Convert it");
            Console.WriteLine("\t1 - C° to F°");
            Console.WriteLine("\t2 - F° to C°");
            HeaMath();
        }

        double FUnitTemp = 1.8;
        double CUnitTemp = 1.8;
        string Fahrenheit = "F°";
        string Celsius = "C°";

        public void HeaMath()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    CalcHeat(FUnitTemp, Celsius, Fahrenheit);
                    break;
                case "2":
                    CalcHeat(CUnitTemp, Fahrenheit, Celsius);
                    break;

            }
        }
        public void CalcHeat(double input, string type1, string type2)
        {
            Console.Clear();
            Console.WriteLine($"\nHow do we do this");
            Console.WriteLine($"\nI know That 1 {type2} is equivalent to {input} {type1}");
            Console.WriteLine($"\nBut we need to find what {heat}{type1} is in {type2}");
            Console.WriteLine($"\nLet's do this {heat} * {input}");
            Console.WriteLine(Math.Round(heat * input, 1) + $" {type1}");
            Console.ReadKey();
            Restart();
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
                    HeatBegin();
                    break;
                case "m":
                    mm.Menu();
                    break;
            }
        }

    }
}
