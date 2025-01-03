namespace app.Models
{
    public class ex052
    {
        public void NumeroPrimo()
        {
            Console.WriteLine("Digite Um Número Para Ver se é primo");
            int num = int.Parse(Console.ReadLine());
            int total = 0;

            for (int c = 1; c <= num; c++)
            {
                if (num % c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{c} ");
                    total += 1;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{c} ");
                }
                Console.ResetColor();
            }
            Console.Write($"\nO Número {num} FOi divisivel {total} vezes");
            Console.WriteLine();

            string resultado = (total == 2) ? "E por isso ele é Primo" : "E por isso ele não é primo";

            Console.WriteLine(resultado);

        }
    }
}