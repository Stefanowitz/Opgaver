using System;
using System.Collections.Generic;
using System.Text;

namespace Calcolator
{

    class Weight
    {
        public static MainMenu mm = new MainMenu();

        double weight = 0;
        public void WeightBegin()
        {
            Console.Clear();
            Console.WriteLine("Okay Weight Let's Begin, What is the Weight");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now you have to pick how i shall Convert it");
            Console.WriteLine("\t1 - Kg to Lbs");
            Console.WriteLine("\t2 - Lbs to Kg");
            WeiMath();
        }

        double lbsUnitMass = 2.204623;
        double kgUnitMass = 0.4535923;
        string kilograms = "kg";
        string lbs = "Lbs";
        public void WeiMath()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    CalcWeight(lbsUnitMass, kilograms, lbs);
                    break;
                case "2":
                    CalcWeight(kgUnitMass, lbs, kilograms);
                    break;

            }

        }
        public void CalcWeight(double input, string type1, string type2)
        {
            Console.Clear();
            Console.WriteLine($"\nHow do we do this");
            Console.WriteLine($"\nI know That 1 {type2} is equivalent to {input} {type1}");
            Console.WriteLine($"\nBut we need to find what {weight}{type1} is in {type2}");
            Console.WriteLine($"\nLet's do this {weight} * {input}");
            Console.WriteLine((weight * input) + type1);
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
                    WeightBegin();
                    break;
                case "m":
                    mm.Menu();
                    break;
            }
        }


    }
}
