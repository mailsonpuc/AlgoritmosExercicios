
namespace app.Models
{
    public class ex074
    {
        public void MairEmenorValorEmLista()
        {
            Random n = new Random();

            int[] valores = { n.Next(0, 10), n.Next(0, 10), n.Next(0, 10), n.Next(0, 10), n.Next(0, 10) };

            Console.WriteLine("Eu sortiei os valores ");
            foreach (var item in valores)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine($"O maior valor sorteado foi {valores.Max()}");

            Console.WriteLine($"O menor valor sorteado foi {valores.Min()}");

        }

    }
}