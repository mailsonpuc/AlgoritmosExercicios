using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex020
    {
        public void OrdemDeapresentacao()
        {
            Console.Clear();

            Console.Write("primeiro aluno: ");
            string? n1 = Console.ReadLine();
            Console.Write("segundo aluno: ");
            string? n2 = Console.ReadLine();
            Console.Write("terceiro aluno: ");
            string? n3 = Console.ReadLine();
            Console.Write("quarto aluno: ");
            string? n4 = Console.ReadLine();

            List<string?> lista = new List<string?> { n1, n2, n3, n4 };

            Random random = new Random();
            int n = lista.Count;
            while (n > 1)
            {
                int k = random.Next(n--);
                string? temp = lista[n];
                lista[n] = lista[k];
                lista[k] = temp;
            }
            Console.WriteLine($"a ordem de apresentação sera [ {string.Join(", ", lista)} ]");
        }
    }
}
