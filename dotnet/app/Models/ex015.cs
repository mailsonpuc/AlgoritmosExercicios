using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex015
    {
        public void AluguelDeCarro()
        {
            Console.Clear();

            Console.WriteLine("quantos dias alugado?:");
            double dias = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("quantos km rodado?:");
            double km = Convert.ToInt32(Console.ReadLine());
            double pago = (dias * 60) + (km * 0.15);

            Console.WriteLine($"O total a pagar é de {pago.ToString("F2")} R$");
        }


    }
}