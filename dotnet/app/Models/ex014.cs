using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex014
    {
        public void CelciosParaF()
        {
            Console.Clear();
            Console.WriteLine("Informe a temperatura em C:");

            double c = Convert.ToInt32(Console.ReadLine());
            double f = ((9 * c) / 5) + 32;
            Console.WriteLine($"A temperatura de {c}C corresponde a {f.ToString("F1")} Fahreneit");
        }
    }
}