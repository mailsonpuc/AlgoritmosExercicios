using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace app.Models
{
    public class ex022
    {
        public void NomeDePessoa()
        {
            Console.Clear();

            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();
            string  nomeSemEspaco = nome.Replace(" ", "");
            string[] primeiroNome = nome.Split(" ");
            
            Console.WriteLine("Analizando seu nome...........");
            Thread.Sleep(2000);

            Console.WriteLine($"Seu nome em maiuscula é {nome.ToUpper()}");
            Thread.Sleep(2000);

            Console.WriteLine($"Seu nome em mainuscula é {nome.ToLower()}");
            Thread.Sleep(2000);

            Console.WriteLine($"Seu nome tem ao todo {nomeSemEspaco.Length} letras");
            Thread.Sleep(2000);

            Console.WriteLine($"Seu primeiro nome tem {primeiroNome[0].Length} letras");

        }
    }
}
