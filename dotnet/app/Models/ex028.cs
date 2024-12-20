using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex028
    {
        public void JogoAdivinha()
        {

            Random random = new Random();
            int computador = random.Next(0, 6);

            Console.Write("Em que nome eu persei? ");
            int jogador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("PROCESSANDO");
            System.Threading.Thread.Sleep(400);


            if (jogador == computador)
            {
                Console.WriteLine("Parabens, voce conseguiu me vencer");
            }

            else
            {
                Console.WriteLine($"Ganhei, eu pensei no numero {computador} e não no {jogador}");
            }


        }
    }
}