using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex004
    {
        public void Valor(){
            Console.Clear();

            Console.WriteLine("Digite algo");
            var a = Console.ReadLine();

            Console.WriteLine($"O tipo primitivo  desse valor é {a.GetType()}");
            Console.WriteLine($"So tem espaços? {string.IsNullOrWhiteSpace(a)}");
        }
    }
}