using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex017
    {
        public void Hipotenusa()
        {
            Console.Clear();

            Console.WriteLine("Comprimento do cateto oposto?");

            double co = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Comprimento do cateto adjacente?");
            double ca = Convert.ToDouble(Console.ReadLine());


              double hi = Math.Sqrt(Math.Pow(co, 2) + Math.Pow(ca, 2));
            
            //(co ** 2 + ca ** 2 ) ** (1/2)

            Console.WriteLine($"A hipotenusa vai medir {hi.ToString("F2")}");
        }
    }
}