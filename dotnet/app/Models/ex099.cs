
namespace app.Models
{
    public class ex099
    {
        public void FuncaoQueDescobreOMaior()
        {
            maior(1, 2, 3, 4, 7, 9);
            maior(1, 2, 3);
            maior(1, 2);
            maior();
        }


        static void maior(params int[] num)
        {
            int cont = 0, maior = 0;

            Console.WriteLine("-".PadLeft(40, '-'));

            Console.WriteLine("\nAnalizando Os Valores Passado");
            Thread.Sleep(1000);
            foreach (var valor in num)
            {
                Console.Write($"{valor}");
                Thread.Sleep(100);

                if (cont == 0)
                {
                    maior = valor;
                }
                else
                {
                    if (valor > maior)
                    {
                        maior = valor;
                    }
                }
                cont += 1;

            }
            Console.WriteLine($"\nForam informados {cont} valores ao todo");
            Console.WriteLine($"O maior valor informado foi {maior}");

            Console.WriteLine();
        }


    }
}

