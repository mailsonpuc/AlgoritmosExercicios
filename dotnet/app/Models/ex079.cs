
namespace app.Models
{
    public class ex079
    {
        public void ValoresUnicosEmUmaLista()
        {
            //criando uma lista vazia
            List<int> numeros = new List<int>();

            while (true)
            {
                Console.WriteLine("Digite Um Número");
                int n = int.Parse(Console.ReadLine());

                if (!numeros.Contains(n))
                {
                    numeros.Add(n);
                    Console.WriteLine("Valor Adicionado com sucesso...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor duplicado! Não Vou Adicionar...");
                    Console.ResetColor();
                }


                Console.WriteLine("Quer continuar [S/N]");
                string r = Console.ReadLine().ToUpper().Trim();

                if (r == "S")
                {
                    //Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("-".PadLeft(40, '-'));
            numeros.Sort();
            Console.WriteLine($"Voce digitou os valores");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-".PadLeft(40, '-'));

        }
    }
}