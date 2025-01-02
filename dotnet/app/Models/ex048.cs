using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex048
    {
        public void SomaDeMultiplosDe3()
        {
            int soma = 0;
            int cont = 0;

            for (int num = 1; num <= 500; num++)
            {
                if (num % 2 == 1 && num % 3 == 0)
                {
                    cont += 1;
                    soma += num;
                }
            }
            Console.WriteLine($"A Soma de todos os  {cont} valores solicitados é {soma}");
        }
    }
}