using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex054
    {
        public void GrupoDeMaioridade()
        {
            var atual = DateTime.Today.Year;
            int totalmaior = 0;
            int totalmenor = 0;


            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"Em que Ano a {i} pessoa Nasceu?");
                int nasc = int.Parse(Console.ReadLine());
                int idade = atual - nasc;

                if (idade >= 21)
                {
                    totalmaior += 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Essa Pessoa é Maior de idade");
                }
                else
                {
                    totalmenor += 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Essa Pessoa é Menor de idade");
                }
                Console.ResetColor();
            }


            Console.WriteLine($"Ao Todo Tivemos {totalmaior} Pessoas Maiores de idade");

            Console.WriteLine($"Ao Todo Tivemos {totalmenor} Pessoas Menores de idade");


        }
    }
}