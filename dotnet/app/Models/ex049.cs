using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex049
    {
        public void TabuadaV2()
        {
            Console.WriteLine("Digite um Número para ver sua tabuada");
            short num = short.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
                Console.WriteLine($"{i} X {num} = {i * num} ");
            
        }
    }
}