
namespace app.Models
{
    public class ex060
    {
        public void CalculoFatorial()
        {
            try
            {
                Console.WriteLine("Digite Um Numero para ver seu fatorial");
                int n = int.Parse(Console.ReadLine());
                int c = n;
                int f = 1;

                while (c > 0)
                {
                    if (c > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {c} ");
                        Console.Write($"X");


                    }
                    else
                    {
                        Console.Write($" {c} ");
                        Console.Write($" = ");
                        Console.ResetColor();
                    }

                    f *= c;
                    c -= 1;
                }
                Console.Write(f);
                Console.WriteLine();

            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ocorreu um erro tente novamente.");

            }

            finally
            {
                Console.WriteLine("Volte Sempre.");
                Console.ResetColor();
            }



        }

    }
}