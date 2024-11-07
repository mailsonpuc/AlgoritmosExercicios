using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex012
    {
        public void Promocao()
        {
            Console.Clear();
            Console.WriteLine("Qual opreço do produto? R$:");

            double preco = Convert.ToInt32(Console.ReadLine());

            double novo = preco - (preco * 5 / 100);

            Console.WriteLine($"O produto que custava {preco.ToString("F2")}, na promoção com 5% de desconto vai custa {novo.ToString("F2")}");
        }
    }
}