using System;
using System.Collections.Generic;
using System.Text;

namespace Calcolator
{
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
                    CalcLength(mileUnitLenght);
                    break;
                case "2":
                    CalcLength(kmUnitLenght);
                    break;

            }
        }

        public void CalcLength(double input)
        {
            Console.Clear();
            Console.WriteLine($"\nHow do we do this");
            Console.WriteLine($"\nI know That 1 mile is equivalent to {input} km");
            Console.WriteLine($"\nBut we need to find what {lenght}miles is in km");
            Console.WriteLine($"\nLet's do this {lenght} * {input}");
            Console.WriteLine((lenght * input) + " km");
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
