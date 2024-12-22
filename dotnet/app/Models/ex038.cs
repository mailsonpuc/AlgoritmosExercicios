using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex038
    {
        public void ComparandoNumeros()
        {
            try
            {

                Console.WriteLine($"Segunndo valor ");
                int n1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine($"Primeiro valor ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 > n2)
                    Console.WriteLine($"O primeiro valor é maior");

                else if (n2 > n1)
                    Console.WriteLine($"O segundo valor é maior");

                else
                    Console.WriteLine($"Os Valores são iguais");


            }
            catch (System.Exception)
            {
                Console.WriteLine("Ocorreu um erro, por favor verifique os valor digitado");
            }







        }
    }
}