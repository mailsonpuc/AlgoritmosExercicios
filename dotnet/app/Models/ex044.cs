using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex044
    {
        public void GerenciadoDePagamento()
        {
            Console.WriteLine("------------------LOJAS GUANABARA------------------");


            Console.WriteLine("Preço das Compras R$");
            double preco = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine(@"
FROMAS DE PAGAMENTO
[ 1 ] À Vista Dinheiro/Cheque
[ 2 ] À Vista Cartão 
[ 3 ] 2x No Cartão
[ 4 ] 3x ou mais  no cartão
            ");

            Console.WriteLine("Qual é a forma de pagamento");
            int opcao = Convert.ToInt32(Console.ReadLine());
            double total;
            double parcela;

            switch (opcao)
            {
                case 1:
                    total = preco - (preco * 10 / 100);
                    Console.WriteLine($"Sua compra de R${preco}, vai custar {total} no final");
                    break;

                case 2:
                    total = preco - (preco * 5 / 100);
                    Console.WriteLine($"Sua compra de R${preco}, vai custar {total} no final");
                    break;

                case 3:
                    total = preco;
                    parcela = total / 2;
                    Console.WriteLine($"Sua Comprar será parcelada em 2x de R${parcela}");
                    Console.WriteLine($"Sua compra de R${preco}, vai custar {total} no final");
                    break;

                case 4:
                    total = preco + (preco * 20 / 100);
                    Console.WriteLine("Quantas parcelas");
                    int totalparc = Convert.ToInt32(Console.ReadLine());
                    parcela = total / totalparc;
                    Console.WriteLine($"Sua Compra Será parcelada em 2x de R${parcela} Com Juros");
                    Console.WriteLine($"Sua compra de R${preco}, vai custar {total} no final");
                    break;

                default:
                    Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 5."); Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 5."); Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 4.");
                    break;
            }


        }
    }
}