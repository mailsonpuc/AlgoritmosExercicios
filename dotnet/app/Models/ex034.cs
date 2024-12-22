using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex034
    {
        public void AumentoSalario()
        {
            Console.WriteLine("Qual o salario do funcionario?");
            float salario = float.Parse(Console.ReadLine());

            double novo; // Declare a variável fora do bloco condicional

            if (salario <= 1250)
            {
                novo = salario + (salario * 15.0 / 100.0);
            }


            else
            {
                novo = salario + (salario * 10.0 / 100.0);
            }


            Console.WriteLine($"Quem ganhava R${salario} passa a ganha R${novo}");

        }
    }
}