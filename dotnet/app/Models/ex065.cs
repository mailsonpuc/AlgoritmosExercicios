
namespace app.Models
{
    public class ex065
    {
        public void maiorEmeno2()
        {
            string resp = "S";
            int soma = 0;
            int quant = 0;
            int maior = 0;
            int menor = 0;
            double media = 0;

            while (resp == "S")
            {
                Console.WriteLine("Digite Um Número");
                int num = int.Parse(Console.ReadLine());

                soma += num;
                quant += 1;

                if (quant == 1)
                {
                    maior = menor = num;
                }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    if (num < menor)
                    {
                        menor = num;
                    }

                }
                Console.WriteLine("Quer Continuar? [S/N]");
                resp = Console.ReadLine().ToUpper().Trim();
            }

            media = (double)soma / quant;
            Console.WriteLine($"Voce digitou {quant} números e a média foi {media}");
            Console.WriteLine($"O maior valor foi {maior} e o menor foi {menor}");

        }
    }
}