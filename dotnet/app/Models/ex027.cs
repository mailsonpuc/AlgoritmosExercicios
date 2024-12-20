using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex027
    {
        public void PrimeiroEultimoNome()
        {

            const string n = "Gaby Garcia Severino Pereira";
            var nome = n.Split(" ");

            Console.WriteLine($"Seu Primeiro nome é {nome[0]}");
            Console.WriteLine($"Seu Ultimo nome é {nome[nome.Length -1]}");


        }
    }
}