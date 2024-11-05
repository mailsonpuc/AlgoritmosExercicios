using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex008
    {
        public void Medida()
        {
            Console.Clear();

            Console.WriteLine("Uma medida em metro: ");
            double medida = Convert.ToDouble(Console.ReadLine());
            var cm = medida * 100;
            var mm = medida * 1000;
            Console.WriteLine($"A medida de {medida}m corresponde a {cm}cm e {mm}mm");
        }
    }
}