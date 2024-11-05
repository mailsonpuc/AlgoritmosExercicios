using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex009
    {
        public void Tabuada(){
            Console.Clear();
            
            Console.WriteLine("Digite um numero para ver sua tabuada");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------------------");
            for(int num=1;num<=10;num++)
            {
                Console.WriteLine($"{numero} X {num} = {numero * num}");
            }

            Console.WriteLine("--------------------------------------");
            
        }
    }
}