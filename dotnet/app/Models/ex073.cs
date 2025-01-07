using System;
using System.Collections.Generic;
using System.Linq;

namespace app.Models
{
    public class ex073
    {
        public void listaComTimesDeFutebol()
        {
            string[] times = { "Botafogo", "Palmeiras", "Flamengo", "Fortaleza", "São Paulo",
                              "Corinthians", "Bahia", "Cruzeiro", "Vasco da Gama", "EC Vitória",
                              "Atlético-MG", "Fluminense", "Grêmio", "Juventude", "Athletico-PR",
                              "Criciúma", "Atlético-GO", "Cuiabá" };


            //Utilizando o método Take do LINQ, 
            //você pode facilmente extrair um número 
            ////específico de elementos 
            ///de uma lista ou array em C#

            var cincoPrimeiros = times.Take(5);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Os 5 primeiros times são:");
            Console.WriteLine("-------------------------------------------");


            foreach (var time in cincoPrimeiros)
            {
                Console.WriteLine("- " + time);
            }



            // Obtém o número total de elementos na lista
            int totalTimes = times.Length;

            // Pula todos os elementos, exceto os últimos 4
            var quatroUltimos = times.Skip(totalTimes - 4).Take(4);

            // Imprime os quatro últimos times
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Os 4 últimos times são:");
            Console.WriteLine("-------------------------------------------");
            foreach (var time in quatroUltimos)
            {
                Console.WriteLine("- " + time);
            }


            // Ordenando a lista em ordem alfabética
            var timesOrdenados = times.OrderBy(t => t);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("EM ORDEM ALFABETICA:");
            Console.WriteLine("-------------------------------------------");

            // Imprimindo os times ordenados
            foreach (var time in timesOrdenados)
            {
                Console.WriteLine(time);
            }



            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"PEOCURANDO SÂO PAULO NA LISTA ");
            Console.WriteLine("-------------------------------------------");
            string  timeProcurado = "São Paulo";
            string timeEncontrado = times.FirstOrDefault(t => t==timeProcurado);
            Console.WriteLine(timeEncontrado);




        }
    }
}