using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex037
    {
        public void ConversoBaseNumerica()
        {
            Console.WriteLine("Digite um Numero inteiro");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
            [ 1 ] Converter para BINARIO
            [ 2 ] Converter para OCTAL
            [ 3 ] Converter para HEXDECIMAL
            ");

            Console.WriteLine("Sua Opção?");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Binario");
                    string binario = Convert.ToString(numero, 2);
                    Console.WriteLine(binario);
                    break;

                case 2:
                    Console.WriteLine("Octal");
                    string octal = Convert.ToString(numero, 8);
                    Console.WriteLine(octal);
                    break;

                case 3:
                    Console.WriteLine("Hexdecimal");
                    string hexdecimal = Convert.ToString(numero, 16);
                    Console.WriteLine(hexdecimal);

                    break;

                default:
                    Console.WriteLine("Invalido");
                    break;
            }


        }
    }
}