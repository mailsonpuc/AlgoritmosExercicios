

namespace app.Models
{
    public class ex100
    {
        //programa principal
        public void FuncaoParaSortearEsomar()
        {
            List<int> numeros = new List<int>();
            Sorteia(numeros);
            Console.WriteLine(string.Join(", ", numeros));

            somPar(numeros);

        }



        //------------------------------------------------------------
        static void Sorteia(List<int> lista)
        {
            Console.Write("Sorteando 5 valores da lista: ");
            Random rand = new Random();
            for (int cont = 0; cont < 5; cont++)
            {
                //numero aleatorio
                lista.Add(rand.Next(1, 11));
            }
        }
        //------------------------------------------------------------



        static void somPar(List<int> lista)
        {
            int soma = 0;

            foreach (var valor in lista)
            {
                if (valor % 2 == 0)
                {
                    soma += valor;
                }
            }
            Console.WriteLine($"Somando os valores pares de {string.Join(", ", lista)}, temos {soma}");

        }

        //------------------------------------------------------------




    }
}