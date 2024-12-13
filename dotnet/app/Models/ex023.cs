using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex023
    {
        public void UnidadeDezenaCentena()
        {
            Console.Clear();

            int num = 1997;


            int u = num / 1 % 10;
            int d = num / 10 % 10;
            int c = num / 100 % 10;
            int m = num / 1000 % 10;

            Console.WriteLine($"Analizando o numero {num}");

            Console.WriteLine($"Unidade {u}");
            Console.WriteLine($"Dezena  {d}");
            Console.WriteLine($"Centena {c}");
            Console.WriteLine($"Milhar  {m}");


        }
    }
}