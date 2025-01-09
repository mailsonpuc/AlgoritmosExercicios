using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex081
    {
        public void ExtraindoDadosDeUmaLista()
        {
            //lista de int vazia
            List<int> valores = new List<int>();

            while (true)
            {
                Console.WriteLine("Digite um Valor");
                valores.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Quer continuar? [S/N]");
                string resp = Console.ReadLine().ToUpper().Trim();

                if (resp == "S")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

            Linha();
            Console.WriteLine($"Voce digitou {valores.Count()} valores");
            Linha();

            var numerosDecrescente = valores.OrderByDescending(n => n);
            Console.WriteLine("Os Valores em ordem decrescente são ");

            foreach (var item in numerosDecrescente)
            {
                Console.Write($" {item} ");
            }


            Console.WriteLine();
            
            int valorProcurado = 5;

            if (valores.Contains(valorProcurado))
                Console.WriteLine("O valor 5 faz parte da lista");
            
            else
                Console.WriteLine("O valor 5 NÂO faz parte da lista");






            static void Linha()
            {
                Console.WriteLine("-".PadLeft(30, '-'));
            }

        }
    }
}