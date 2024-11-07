using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex011
    {
        public void PintaParede()
        {
            Console.Clear();

            Console.WriteLine("Altura da parede");
            int larg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largura da parede");
            int alt = Convert.ToInt32(Console.ReadLine());
            
            double area = larg * alt;
            double tinta = area /2;

            Console.WriteLine($"Sua parede tem a dimeção de de {larg}X{alt} e sua area é de {area}");

            Console.WriteLine($"Para pintar essa parede voce preisara de {tinta}l de tinta");



        }
    }
}