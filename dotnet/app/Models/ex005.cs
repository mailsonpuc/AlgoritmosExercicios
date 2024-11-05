using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex005
    {
        public  void SucessoEantecessor(){
            Console.Clear();
            
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine($"Analizado o numero {numero}, seu antecessor é {antecessor} e o sucessor é {sucessor}");


        }
    }
}