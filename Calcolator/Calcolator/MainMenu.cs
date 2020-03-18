using System;
using System.Collections.Generic;
using System.Text;

namespace Calcolator
{
    class MainMenu
    {
        public static Cal calc = new Cal();
        public static Distance dis = new Distance();
        public static Weight wei = new Weight();

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello there how can i be of service");
            Console.WriteLine("\t1 - Normal Calculator");
            Console.WriteLine("\t2 - Distance Converter");
            Console.WriteLine("\t3 - Weight Converter");
            //Console.WriteLine("\t4 - Height COnverter");
            Console.WriteLine("Please choose an option");
            switch (Console.ReadLine())
            {
                case "1":
                    calc.CalBegin();
                    break;
                case "2":
                    dis.DisBegin();
                    break;
                case "3":
                    wei.WeightBegin();
                    break;
                        
                    
            }
        }
    }

}
