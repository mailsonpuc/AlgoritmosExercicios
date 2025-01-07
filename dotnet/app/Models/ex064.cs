using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex064
    {
        public void TratandoVariosValores()
        {

            int num = 0;
            int contador = 0;
            int soma = 0;


            Console.WriteLine("Digite um número [999 para parar]");
            num = int.Parse(Console.ReadLine());


            while (num != 999)
            {
                soma += num;
                contador += 1;

                Console.WriteLine("Digite um número [999 para parar]");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acabou");
            Console.WriteLine($"voce digitou {contador} Numeros e a soma é {soma}");
        }
    }
}