using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex047
    {
        public void ComtagemDePares()
        {
            Console.WriteLine("Monstrando numeros pares de 0 a 100");

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i},");
                }
            }
        }
    }
}