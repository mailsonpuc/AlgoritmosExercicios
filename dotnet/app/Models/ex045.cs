using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace app.Models
{
    public class ex045
    {
        public void PedraPapalEtesoura()
        {
            Random random = new Random();

            int computador = random.Next(0, 3);

            string[] itens = { "Pedra", "Papel", "Tesoura" };

            Console.WriteLine(@"
Suas Opçoes:
[ 0 ] PEDRA
[ 1 ] PAPEL
[ 2 ] TESOURA
            ");

            Console.WriteLine("Qual é a sua jogada?");

            short jogador = short.Parse(Console.ReadLine());

            Console.WriteLine("JO");
            Thread.Sleep(1000);
            Console.WriteLine("KEM");
            Thread.Sleep(1000);
            Console.WriteLine("PO!!!");
            Thread.Sleep(1000);


            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Computador Escolheu : {itens[computador]}");
            Console.WriteLine($"Jogador Escolheu : {itens[jogador]}");
            Console.WriteLine("-------------------------------------------------");


            if (computador == 0) //computador jogou pedra
            {
                if (jogador == 0)
                {
                    Console.WriteLine("EMPATE");
                }
                else if (jogador == 1)
                {
                    Console.WriteLine("JOGADOR VENCE");
                }
                else if (jogador == 2)
                {
                    Console.WriteLine("COMPUTADOR VENCE");
                }
                else
                    Console.WriteLine("JOGADA INVALIDA");

            }

            else if (computador == 1) //computador jogou papel
            {

                if (jogador == 0)
                {
                    Console.WriteLine("COMPUTADOR VENCE");
                }
                else if (jogador == 1)
                {
                    Console.WriteLine("EMPATE");
                }
                else if (jogador == 2)
                {
                    Console.WriteLine("JOGADOR VENCE");
                }
                else
                    Console.WriteLine("JOGADA INVALIDA");

            }

            else if (computador == 2) //computador jogou tesoura
            {
                if (jogador == 0)
                {
                    Console.WriteLine("JOGADOR VENCE");
                }
                else if (jogador == 1)
                {
                    Console.WriteLine("COMPUTADOR VENCE");
                }
                else if (jogador == 2)
                {
                    Console.WriteLine("EMPATE");
                }
                else
                    Console.WriteLine("JOGADA INVALIDA");

            }





        }
    }
}