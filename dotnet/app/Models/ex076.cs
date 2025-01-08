using System;
using System.Collections.Generic;

namespace app.Models
{
    public class ex076
    {
        public void listadePrecoComTupla()
        {

            var produtos = new List<(string Nome, double Preco)>
        {
            ("Lápis", 1.75),
            ("Borracha", 2.00),
            ("Caderno", 15.90),
            ("Estojo", 25.00),
            ("Transferidor", 4.20),
            ("Compasso", 9.99),
            ("Mochila", 120.32),
            ("Canetas", 22.30),
            ("Livro", 34.90)
        };


            Linha();
            Console.WriteLine("{0," + ((50 / 2) + ("LISTAGEM DE PREÇOS").Length / 2) + "}", "LISTAGEM DE PREÇOS");

            Linha();

            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Nome.PadRight(40, '.')} R$ {produto.Preco:F2}");
            }

            Linha();
        }

        static void Linha()
        {
            Console.WriteLine("=".PadRight(50, '='));
        }


    }
}