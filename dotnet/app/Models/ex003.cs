using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex003
    {
        public  void SomaDoisNumeros()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite o segundo valor");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A Soma entre {num1} e {num2} é {num1 + num2}");
        }
    }
}