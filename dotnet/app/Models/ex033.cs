using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex033
    {
        public void MaiorEmenorValor()
        {
            Console.WriteLine("Primeiro Valor");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro Valor");
            int c = int.Parse(Console.ReadLine());

            //verificando quem é menor
            int menor = a;

            if (b < a && b < c)
                menor = b;

            if (c < a && c < b)
                menor = c;


            //verificando quem é maior
            int maior = a;

            if (b > a && b > c)
                maior = b;

            if (c > a && c > b)
                maior = c;
            

            Console.WriteLine($"O Menor valor digitado foi {menor}");

            Console.WriteLine($"O Maior valor digitado foi {maior}");







        }
    }
}