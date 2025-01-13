

namespace app.Models
{
    public class ex095
    {
        public void FuncaoCalculadora()
        {
            Linha();
            Console.WriteLine("calculadora".ToUpper());
            Linha();


            Console.WriteLine("Número 1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número 2");
            int n2 = int.Parse(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"A Soma entre {n1} + {n2} é {Soma(n1, n2)}");
            Console.WriteLine($"A Subtraçao entre {n1} - {n2} é {Subtrai(n1, n2)}");
            Console.WriteLine($"A multiplicaçao entre {n1} X {n2} é {Multiplica(n1, n2)}");
            Console.WriteLine($"A Divisão entre {n1} % {n2} é {Divide(n1, n2)}");
            Console.ResetColor();


        }


        static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Subtrai(int n1, int n2)
        {
            return n1 - n2;
        }
        static int Multiplica(int n1, int n2)
        {
            return n1 * n2;
        }

        static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }

        static void Linha()
        {
            Console.WriteLine("-".PadLeft(40, '-'));
        }

    }
}