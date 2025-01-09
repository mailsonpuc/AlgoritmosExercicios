
namespace app.Models
{
    public class ex078
    {
        public void MaiorEmenorValoresNaLista()
        {
            //List<int> listanum = [];
            List<int> listanum = new List<int>();

            int maior = 0;
            int menor = 0;


            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine($"Digite um valor para a Posição {c}");
                listanum.Add(int.Parse(Console.ReadLine()));

                if (c == 0)
                {
                    maior = menor = listanum[c];
                }
                else
                {
                    if (listanum[c] > maior)
                    {
                        maior = listanum[c];
                    }
                    if (listanum[c] < menor)
                    {
                        menor = listanum[c];
                    }
                }

            }


            foreach (var item in listanum)
            {
                Console.Write($" {item} ");
            }


            Console.WriteLine();

            Linha();
            Console.WriteLine($"\nO maior valor digitado foi {maior}");
            Console.WriteLine($"O menor valor digitado foi {menor}");
            Linha();

            static void Linha()
            {
                Console.WriteLine("-".PadLeft(30, '-'));
            }

        }
    }
}