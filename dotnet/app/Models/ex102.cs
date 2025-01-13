using System;

namespace app.Models
{
    public class ex102
    {
        // Método principal para calcular o fatorial
        public void FuncaoParaFatorial()
        {
            long resultado = Fatorial(5, show: true);
            Console.WriteLine($"Resultado final: {resultado}");
           
          
        }

        static long Fatorial(int numero, bool show = false)
        {
           

            if (numero < 0)
                throw new ArgumentException("Número não pode ser negativo.");

            long resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;

                if (show)
                {
                    Console.Write($"{i} ");
                    if (i < numero) // Adiciona 'X' se não for o último número
                    {
                        Console.Write("X ");
                    }
                }
            }

            if (show)
            {
                Console.WriteLine($"= {resultado}"); // se 'show' for true
            }

            return resultado;
        }
    }
}
