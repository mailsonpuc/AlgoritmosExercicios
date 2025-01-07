using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex061
    {
        public void ProgrecaoAritmetica()
        {
            Console.WriteLine("--------------Gerador de pa--------------".ToUpper());
            Console.WriteLine("Primeiro termo".ToUpper());
            int primeiro = int.Parse(Console.ReadLine());
            Console.WriteLine("razão".ToUpper());
            int razao = int.Parse(Console.ReadLine());

            int termo = primeiro;
            int cont = 0;

            while (cont <= 9)
            {
                Console.Write($"{termo} ->");
                termo += razao;
                cont +=1;
            }

            Console.WriteLine(" Fim");

        }
    }
}