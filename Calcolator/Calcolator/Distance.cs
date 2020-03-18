using System;
using System.Collections.Generic;
using System.Text;

namespace Calcolator
{
    class Distance
    {
        public static MainMenu mm = new MainMenu();


        double lenght = 0;
        public void DisBegin()
        {
            Console.Clear();
            Console.WriteLine("Let's Start with somthing simple What is the lenght");
            lenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now you have to pick how i shall Convert it");
            Console.WriteLine("\t1 - KM to Miles");
            Console.WriteLine("\t2 - Miles to KM");
            DisMath();


        }

        double mileUnitLenght = 0.62137;
        double kmUnitLenght = 1.609344;
        string km = "km";
        string mile = "mile(s)";
        public void DisMath()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    CalcLength(mileUnitLenght, km,mile);
                    break;
                case "2":
                    CalcLength(kmUnitLenght,mile,km);
                    break;

            }
        }

        public void CalcLength(double input, string type1, string type2)
        {
            Console.Clear();
            Console.WriteLine($"\nHow do we do this");
            Console.WriteLine($"\nI know That 1 {type2} is equivalent to {input} {type1}");
            Console.WriteLine($"\nBut we need to find what {lenght}{type1} is in {type2}");
            Console.WriteLine($"\nLet's do this {lenght} * {input}");
            Console.WriteLine(Math.Round(lenght * input,2) + $" {type1}");
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
                    DisBegin();
                    break;
                case "m":
                    mm.Menu();
                    break;
            }
        }
    }

}
