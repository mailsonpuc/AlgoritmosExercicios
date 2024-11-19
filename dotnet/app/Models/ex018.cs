using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex018
    {
        public void CalculadoraTrigonometrica()
        {
             Console.Write("Digite o angulo que voce quer: ");
             double angulo = Convert.ToDouble(Console.ReadLine());
             double seno = Math.Sin(DegreeToRadian(angulo));
             double cosseno = Math.Cos(DegreeToRadian(angulo));
             double tangente = Math.Tan(DegreeToRadian(angulo));


             Console.WriteLine($@"
             o Angulo de {angulo} tem o seno de: {seno:F2},
             Cosseno: {cosseno:F2},
             Tangente: {tangente:F2}
            ");
        }


        // Função para converter graus para radianos
        static double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }

    }
}