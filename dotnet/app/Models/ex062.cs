using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex062
    {
        public void GeradorDePA2()
        {

            Console.WriteLine("--------------Gerador de pa--------------".ToUpper());
            Console.WriteLine("Primeiro termo".ToUpper());
            int primeiro = int.Parse(Console.ReadLine());
            Console.WriteLine("razão".ToUpper());
            int razao = int.Parse(Console.ReadLine());

            int termo = primeiro;
            int cont = 0;
            int total = 0;
            int mais = 9;

            while (mais != 0)
            {
                total += mais;

                while (cont <= total)
                {
                    Console.Write($"{termo} ->");
                    termo += razao;
                    cont += 1;
                }

                Console.WriteLine("PAUSA");
                Console.WriteLine("Quantos termos vocẽ que mostrar a mais? sair 0");
                mais = int.Parse(Console.ReadLine());
            }
            
             Console.WriteLine($"progressão finalizada com {total} termos mostrados");


        }
    }
}