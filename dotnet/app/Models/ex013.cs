using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex013
    {
        public void AumentoSalario()
        {
            Console.Clear();

            Console.WriteLine("Qual salario de um funcionario? ");
            double salario = Convert.ToInt32(Console.ReadLine());
            double novo = salario + (salario * 15 / 100);

            Console.WriteLine($"Um funcionario que ganhava {salario}R$. com 15% de aumento, passa aganha R${novo}");

        }

    }
}