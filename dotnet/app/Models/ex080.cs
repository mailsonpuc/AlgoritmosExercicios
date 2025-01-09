
namespace app.Models
{
    public class ex080
    {
        public void ListaOrdenadaSemRepeticao()
        {
            List<int> lista = new List<int>();

            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Digite um valor");
                int n = int.Parse(Console.ReadLine());

                if (c == 0)
                {
                    lista.Add(n);
                    Console.WriteLine("Adicionado no final da lista..");
                }

                //se o n for maior que o ultimo elemento da lista
                else if (n > lista.Last())
                {
                    lista.Add(n);
                }

                else
                {
                    int pos = 0;
                    //se pos for menor que o tamano da lista
                    while (pos < lista.Count())
                    {
                        if (n <= lista[pos])
                        {
                            lista.Insert(pos, n);
                            Console.WriteLine($"Adicionado na POSIÇÃO {pos} da lista");
                            break;
                        }
                        pos += 1;

                    }
                }
            }

            Console.WriteLine("-".PadLeft(40, '-'));
            Console.WriteLine("Os Valores digitados foram");
            Console.WriteLine("-".PadLeft(40, '-'));

            foreach (var item in lista)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();


        }
    }
}