using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex055
    {
        public void MaieEmenorDaSequencia()
        {
            double maior = 0;
            double menor = 0;

            for (int p = 1; p < 6; p++)
            {
                Console.WriteLine($"Peso da {p} Pessoa");
                double peso = double.Parse(Console.ReadLine());

                if (p == 1)
                {
                    maior = peso;
                    menor = peso;
                }
                else
                {
                    if (peso > maior)
                    {
                        maior = peso;
                    }
                    if (peso < menor)
                    {
                        menor = peso;

                    }
                }

            }
            Console.WriteLine($"O Maior peso lido foi de {maior} KG");

            Console.WriteLine($"O Menor peso lido foi de {menor} KG");
        }
    }
}