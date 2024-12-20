using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex031
    {
        public void PrecoDeViagem()
        {
            Console.WriteLine("Qual é a distancia da sua viagem? ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Voce esta prestes a começar um VIaGem de {d}KM");

            if (d <= 200)
            {
                double preco = d * 0.50;

                Console.WriteLine($"E o preço da sua passagem sera de {preco}R$");
            }
            else
            {
                double preco = d * 0.45;

                Console.WriteLine($"E o preço da sua passagem sera de {preco}R");
            }

        }
    }
}