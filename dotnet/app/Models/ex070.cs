
using System.Globalization;

namespace app.Models
{
    public class ex070
    {
        public void EstatisticaEmProduto()
        {
            double total = 0;
            double totmil = 0;
            double menor = 0;
            double cont = 0;
            string barato = "";


            while (true)
            {
                Console.WriteLine("Nome do produto");
                string produto = Console.ReadLine();
                Console.WriteLine("Preço do produto R$ Ex: 5.50");
                double preco = double.Parse(Console.ReadLine());
                cont += 1;
                total += preco;
                if (preco > 1000)
                    totmil += 1;

                if (cont == 1){
                    menor = preco;
                    barato = produto;
                }
                else
                {
                    if (preco < menor)
                    {
                        menor = preco;
                        barato = produto;
                    }
                }

                string resp = "";

                while (resp != "S" && resp != "N")
                {
                    Console.WriteLine("Quer continuar? [S/N]");
                    resp = Console.ReadLine().ToUpper().Trim();
                }
                if (resp == "N")
                {
                    break;
                }


            }
            Console.WriteLine("-------------------FIM DO PROGRAMA-------------------");
            CultureInfo cultura = new CultureInfo("pt-BR");

            Console.WriteLine($"O total da comprar foi de {total.ToString("F2", cultura)}");
            Console.WriteLine($"temos {totmil} produtos custando mais de R$ 1000.00");
            Console.WriteLine($"O produto mais barato foi {barato} que custa R${menor.ToString("F2", cultura)}");
        }
    }
}