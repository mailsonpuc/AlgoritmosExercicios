using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex032
    {
        public void anoBissexto()
        {
            Console.WriteLine("Que ano quer analisar?: coloque 0 para analisar o ano atual");

            int ano = int.Parse(Console.ReadLine());

            if (ano == 0)
            {
                ano = DateTime.Now.Year;

            }

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"O ano {ano} é BISSEXTO");
            }
            else
            {
                Console.WriteLine("O ano não é BISSEXTO");
            }


        }
    }
}