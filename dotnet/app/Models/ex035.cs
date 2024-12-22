using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex035
    {
        public void Triangulo()
        {
            Console.WriteLine("Primeiro Seguimento");
            float r1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Seguimento");
            float r2 = float.Parse(Console.ReadLine());


            Console.WriteLine("Terceiro Seguimento");
            float r3 = float.Parse(Console.ReadLine());

            if (r1 < r2 + r3 && r2 < r1 + r3 && r3 < r1 + r2)
                Console.WriteLine("Os seguimentos acima podm formar triangulo");

            else
                Console.WriteLine("Os seguimentos acima NÂO podm formar um triangulo");



        }
    }
}