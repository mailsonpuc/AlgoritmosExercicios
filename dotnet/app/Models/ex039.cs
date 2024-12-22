using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex039
    {
        public void AlistamentoMilitar()
        {
            DateTime atual = DateTime.Now;
            int anoAtual = atual.Year; // Usa o ano diretamente como inteiro

            Console.WriteLine("Ano de Nascimento:");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - nascimento;

            Console.WriteLine($"Idade: {idade}");

            if (idade < 18)
                Console.WriteLine("Ainda não está na idade de se alistar.");

            else if (idade == 18)
                Console.WriteLine("Está na idade de se alistar.");

            else
                Console.WriteLine("Já passou da idade de se alistar.");

        }

    }
}