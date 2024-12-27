using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex040
    {
        public void MediaDeNota()
        {
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;


            Console.WriteLine($"Tirando {nota1} e {nota2} a media do aluno é {media}");

            if (media >= 5 && media < 7)
                Console.WriteLine("O aluno esta em RECUPERAÇÂO");


            else if (media < 5)
                Console.WriteLine("O ALuno está aprovado");

            else
                Console.WriteLine("O ALuno está aprovado");


        }
    }
}