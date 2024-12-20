using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex029
    {
        public void MultaDeVelocidade()
        {
            Console.WriteLine("Qual a velocidade atual do carro?");
            int velocidade = int.Parse(Console.ReadLine());
            if (velocidade >80)
            {
                Console.WriteLine("Multado voce excedeu o limite permitido que é de 80Km");
                double  multa = (velocidade-80) * 7;
                Console.WriteLine($"Voce dever pagar uma multar de {multa}R$.");
            }
            else
              Console.WriteLine("Tenham um bom dia!");
        }
    }
}