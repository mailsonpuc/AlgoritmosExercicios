
using System.Net.Mail;

namespace app.Models
{
    public class ex082
    {
        public void DividindoValoresEmVariasListas()
        {
            //-----------------------------------
            List<int> num = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            //-----------------------------------

            while (true)
            {
                Console.WriteLine("Digite Um Número");
                num.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Quer Continuar? [S/N]");
                string resp = Console.ReadLine().ToUpper().Trim();

                if (resp == "S")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }




            for (int i = 0; i < num.Count; i++)
            {
                //Console.WriteLine($"Indice: {i}, Valor: {num[i]}");
                //se valor for dividido por zero
                if (num[i] % 2 == 0)
                {
                    pares.Add(num[i]);
                }

                else if (num[i] % 2 == 1)
                {
                    impares.Add(num[i]);
                }


            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-".PadLeft(40, '-'));
            Console.WriteLine("A lista completa é");
            foreach (var item in num)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            Console.WriteLine("-".PadLeft(40, '-'));
            Console.ResetColor();



            Console.WriteLine("-".PadLeft(40, '-'));
            Console.WriteLine("A lista de pares é");
            foreach (var item in pares)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            Console.WriteLine("-".PadLeft(40, '-'));



            Console.WriteLine("-".PadLeft(40, '-'));
            Console.WriteLine("A lista impares é");
            foreach (var item in impares)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            Console.WriteLine("-".PadLeft(40, '-'));



        }
    }
}