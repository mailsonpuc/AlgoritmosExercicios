namespace app.Models
{
    public class ex063
    {
        public void SequenciaDeFibonacci()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------sequencia de fibonacci------------------".ToUpper());
            Console.ResetColor();

            Console.WriteLine("Quantos termos vocẽ quer mostrar?");
            int n = int.Parse(Console.ReadLine());

            int t1 = 0;
            int t2 = 1;
            int cont = 3;

            Console.Write($"{t1} -> {t2}");

            while (cont <= n)
            {
                int t3 = t1 + t2;
                Console.Write($" -> {t3}");
                t1 = t2;
                t2 = t3;
                cont += 1;
            }

            Console.WriteLine("-> FIM");


        }
    }
}