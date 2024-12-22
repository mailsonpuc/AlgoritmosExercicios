using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex036
    {
        public void AprovandoEmprestimos()
        {   
            Console.WriteLine("Valor da casa");
            float casa = float.Parse(Console.ReadLine());

            Console.WriteLine("Salario do Comprador");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantos anos de financiamento?");
            int anos = int.Parse(Console.ReadLine());

            double prestacao = casa / (anos * 12.0);
            double minimo = salario * 30 / 100;


            Console.WriteLine($"Para pagar uma casa de R${casa} em {anos} anos, a prestação será de R${prestacao}");
            

            if (prestacao <= minimo)
                Console.WriteLine("Emprestimo pode ser CONCEDIDO");

            else
                Console.WriteLine("Emprestimo NEGADO");
            
        }
    }
}