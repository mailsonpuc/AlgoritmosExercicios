using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex010
    {
        public void RealToDolar()
        {
            Console.Clear();
            
            Console.WriteLine("quanto dinheiro vc tem na carteira R$ ?:");

            double real = Convert.ToDouble(Console.ReadLine());

            double dolar = real / 5.75;

            Console.WriteLine($"com  R$ {real} voce pode comprar U$ {dolar}");


        }
    }
}