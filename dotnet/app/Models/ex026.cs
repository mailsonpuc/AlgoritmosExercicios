using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex026
    {
        public void FraseLettraA()
        {
            string frase = "Arara Azul".ToLower().Trim();

            Console.WriteLine($"A letra A aparece {frase.Split('a').Length - 1} vezes na frase");
            Console.WriteLine($"A primeira letra A aparece na posição {frase.IndexOf('a') + 1}");
            Console.WriteLine($"A ultima letra A aparece na posição {frase.LastIndexOf('a') + 1}");

        }
    }
}