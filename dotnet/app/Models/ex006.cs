using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex006
    {
        public void DobroTriploEraiz()
        {
            Console.Clear();

            Console.WriteLine("Digite Um Numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            int Dobro = numero * 2;
            int Triplo = numero * 3;
            var Raiz = Math.Sqrt(numero);

            Console.WriteLine($"O dobro de {numero} valer {Dobro}");

            Console.WriteLine($"O Triplo de {numero} valer {Triplo}");

            Console.WriteLine($"A Raiz de {numero} valer {Raiz}");
        
        }
    }
}