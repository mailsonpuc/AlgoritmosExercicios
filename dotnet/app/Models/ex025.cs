using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex025
    {
        public void TemSilvaNoNome()
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine().ToLower().Trim();
            bool verificar = nome.Contains("silva");

            Console.WriteLine($"Seu nome tem Silva? {verificar}");

        }
    }
}