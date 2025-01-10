

namespace app.Models
{
    public class ex085
    {
        public void ListaComParesEimpares()
        {
            //                                             lista 0             lista 1
            List<List<int>> num = new List<List<int>> { new List<int>(), new List<int>() };
            int valor = 0;

            for (int c = 1; c < 8; c++)
            {
                Console.Write("Digite Um Valor: ");
                valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    //par
                    num[0].Add(valor);
                }
                else
                {
                    //impares
                    num[1].Add(valor);
                }
            }



            num[0].Sort();
            num[1].Sort();

            Console.WriteLine($"pares digitados foram:){string.Join(", ", num[0])}");
            Console.WriteLine($"impares digitados foram: {string.Join(", ", num[1])}");

        }
    }
}