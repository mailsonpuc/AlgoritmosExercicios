using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex091
    {
        public void JogandoDadosEmCsharp()
        {

            Dictionary<string, object> jogo = new Dictionary<string, object>();


            jogo["jogador1"] = new Random().Next(1, 6);
            jogo["jogador2"] = new Random().Next(1, 6);
            jogo["jogador3"] = new Random().Next(1, 6);
            jogo["jogador4"] = new Random().Next(1, 6);

            // Ordenar por valores em ordem crescente
            var ordenadoPorValores = jogo.OrderBy(par => par.Value);

            // Exibir o dicionário ordenado
            Console.WriteLine("Ordenado por valores (crescente):");
            foreach (var item in ordenadoPorValores)
            {

                Console.WriteLine($"{item.Key} tirou  {item.Value} no dado");
                Thread.Sleep(1000);
            }

        }
    }
}