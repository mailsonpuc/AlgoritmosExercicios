using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex050
    {
        public void SomaDosPares()
        {
            int soma = 0;
            int contador = 0;

            for (int valor = 1; valor <= 6; valor++)
            {
                Console.WriteLine($"Digite o {valor} Valor");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    soma += numero;
                    contador += 1;
                }

            }


            Console.WriteLine($"Voce informou  {contador}  números PARES, e sua soma é {soma}");

        }
    }
}