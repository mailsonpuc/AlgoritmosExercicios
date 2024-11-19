using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex019
    {
        public void EscolherAluno()
        {
            Console.Clear();
            Console.Write("Primeiro aluno: ");
            string n1 = Console.ReadLine();
            Console.Write("Segundo aluno: ");
            string n2 = Console.ReadLine();
            Console.Write("Terceiro aluno: ");
            string n3 = Console.ReadLine();
            Console.Write("Quarto aluno: ");
            string n4 = Console.ReadLine();

            List<string> lista = new List<string> { n1, n2, n3, n4 };

            Random random = new Random();
            string escolhido = lista[random.Next(lista.Count)];

            Console.WriteLine($"O aluno escolhido foi {escolhido}");
        }
    }
}
