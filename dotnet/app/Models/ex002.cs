using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex002
    {
        //public string? Nome { get; set; }

        public void Nome()
        {
            Console.Clear();

            Console.WriteLine("Digite Seu Nome");
            string? nome = Console.ReadLine();

            Console.WriteLine($"É um prazer te conhece {nome}");
        }


    }
}