
namespace app.Models
{
    public class ex059
    {
        public void Menu()
        {
            Console.WriteLine("Primeiro Valor");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            int n2 = int.Parse(Console.ReadLine());

            int opcao = 0;
            int maior = 0;

            while (opcao != 5)
            {

                Console.WriteLine(@"
[ 1 ] soma
[ 2 ] multiplicar
[ 3 ] maior
[ 4 ] novo numero
[ 5 ] sair do programa
                ");

                Console.WriteLine("Qual é sua opção?");
                opcao = int.Parse(Console.ReadLine());
                LimpaTela();

                switch (opcao)
                {


                    case 1:
                        int soma = n1 + n2;
                        Console.WriteLine($"A soma entre {n1} + {n2} é igual a {soma}");
                        break;
                    case 2:
                        int produto = n1 * n2;
                        Console.WriteLine($"O resultado entre {n1} X {n2} é igual a {produto}");
                        break;
                    case 3:
                        if (n1 > n2)
                            maior = n1;

                        else
                            maior = n2;
                        Console.WriteLine($"Entre {n1} e {n2} o maior é {maior}");
                        break;
                    case 4:
                        Console.WriteLine("Informe os numeros novamente ");
                        Console.WriteLine("Primeiro Valor");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Valor");
                        n2 = int.Parse(Console.ReadLine());


                        break;
                    case 5:
                        Console.WriteLine("Finalizando");
                        break;

                    default:
                        Console.WriteLine("Opçao invalida. Tente Novamente");
                        break;
                }



            }
            Console.WriteLine("FIm do Programa, volte Sempre!!!!!!!");

        }

        static void LimpaTela()
        {
            Console.Clear();
        }


    }
}