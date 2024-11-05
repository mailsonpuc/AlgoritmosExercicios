using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex007
    {
        public void NotaDoAluno()
        {
            Console.Clear();

            Console.WriteLine("Primeira nota do aluno");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segunda nota do aluno");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            double Media = (nota1 + nota2) / 2;

            Console.WriteLine($"A media entre {nota1} e {nota2} é igual a {Media}");


        }
    }
}