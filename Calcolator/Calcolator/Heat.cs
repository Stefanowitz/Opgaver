using System;
using System.Collections.Generic;
using System.Text;

namespace Calcolator
{
    class Heat
    {
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

        public void HeaMath()
        {

        }
    }
}
