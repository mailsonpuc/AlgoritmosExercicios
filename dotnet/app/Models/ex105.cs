using System;
using System.Globalization;

namespace app.Models
{
    public class ex105
    {
        public void ExercitandoFuncao()
        {
            // cultura brasileira
            CultureInfo brl = new CultureInfo("pt-BR");

            Console.WriteLine("Digite o preço R$");
            double p = double.Parse(Console.ReadLine());

            linha();
            cor();
            Console.WriteLine($"A metade de {p.ToString("C", brl)} é {metade(p).ToString("C", brl)}");
            Console.WriteLine($"O dobro de {p.ToString("C", brl)} é {dobro(p).ToString("C", brl)}");
            Console.WriteLine($"O aumento de 10% de {p.ToString("C", brl)} é {aumenta(p, 10).ToString("C", brl)}");
            Console.WriteLine($"A redução de 5% de {p.ToString("C", brl)} é {diminuir(p, 5).ToString("C", brl)}");
            feixaCor();
            linha();
        }



        public double aumenta(double preco, double taxa)
        {
            return preco + (preco * taxa / 100);
        }

        public double diminuir(double preco, double taxa)
        {
            return preco - (preco * taxa / 100);
        }

        public double dobro(double preco)
        {
            return preco * 2;
        }

        public double metade(double preco)

        {
            return preco / 2;
        }


        static void linha()
        {
            Console.WriteLine("-".PadLeft(40, '-'));
        }


        static void cor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void feixaCor()
        {
            Console.ResetColor();
        }
    }
}
