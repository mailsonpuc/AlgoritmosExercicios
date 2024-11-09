using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex016
    {
        public void ConvertFloatToInte()
        {
            Console.Clear();

            Console.Write("Digite um valor decimal: ");
            decimal numero = Convert.ToDecimal(Console.ReadLine());

            int inteiro = Convert.ToInt32(numero);

            Console.WriteLine($"O valor digitado foi {numero} e sua porção inteira é {inteiro}");


        }
    }
}