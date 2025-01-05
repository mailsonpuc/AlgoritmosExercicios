using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex058
    {
        public void JogoDeAdivinhacao()
        {

            Random random = new Random();

            int computador = random.Next(0, 100);
            // Console.WriteLine(computador);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Acabei de pensar em um número entre 0 e 100, qual foi");
            //---------------------------------
            bool acertou = false;
            int palpite = 0;
            //---------------------------------
            Console.ResetColor();


            while (acertou != true)
            {
                Console.WriteLine("Qual é seu Palpite?");
                int jogador = int.Parse(Console.ReadLine());
                palpite += 1;

                if (jogador == computador)
                {
                    acertou = true;
                }
                else
                {
                    if (jogador < computador)
                    {
                        Console.WriteLine("Mais.... Tente mais uma vez");
                    }
                    else if (jogador > computador)
                    {
                        Console.WriteLine($"Menos.... Tente mais uma vez");
                    }

                }


            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Acertou com {palpite} Tentativas");

            Console.ResetColor();

        }
    }
}