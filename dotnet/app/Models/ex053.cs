using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex053
    {
        public void Polindromo()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().Trim().ToUpper();
            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string junto = string.Join("", palavras);
            string inverso = "";

            for (int letra = junto.Length - 1; letra >= 0; letra--)
            {
                inverso += junto[letra];
            }

            string resultado = (junto == inverso) ? "Temos um Palindromo" : "A frase digitada não é um palindromo";
            Console.WriteLine(resultado);
            Console.Write($"{junto} ---> {inverso}");
            Console.WriteLine();
        }
    }
}