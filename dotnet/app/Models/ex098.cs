using System;
using System.Threading;

namespace app.Models
{
    public class ex098
    {
        public void FuncaoDeContador()
        {
            contador(1, 10, 1);
            contador(10, 1, 2);
        }

        static void contador(int i, int f, int p)
        {
            Console.WriteLine($"Contagem de {i} até {f} de {p} em {p}:");

            if (i < f)
            {
                for (int cont = i; cont <= f; cont += p)
                {
                    Console.Write($" {cont} ");
                    Thread.Sleep(100);
                }
                Console.WriteLine("FIM");
            }
            else
            {
                for (int cont = i; cont >= f; cont -= p)
                {
                    Console.Write($" {cont} ");
                    Thread.Sleep(100);
                }
                Console.WriteLine("FIM");
            }
        }
    }
}
