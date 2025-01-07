using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex067
    {
        public void TabuadaDeQualqueValor()
        {
            while (true)
            {

                Console.WriteLine("Que ver a tabuada de qual Valor? [00] para sair");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 00)
                    break;

                Console.Clear();
                for (int num = 1; num <= 10; num++)
                {
                    Console.WriteLine($"{numero} X {num} = {numero * num}");
                }

            }
            Console.WriteLine("ACABOU");


        }
    }
}