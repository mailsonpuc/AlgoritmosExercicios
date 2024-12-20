using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex030
    {
        public void ParOuImpar()
        {
            Console.WriteLine("Diite qualquer Numero");
            int numero =int.Parse(Console.ReadLine());

            if(numero %2==0)
            {
                Console.WriteLine("O Numero digitado é par");
            }

            else
              Console.WriteLine("O numero é impar");



        }
    }
}