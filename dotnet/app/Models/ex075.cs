namespace app.Models
{
    public class ex075
    {
        public void AnaliseDeDadosEmLista()
        {
            int[] valores = new int[4];

            Console.WriteLine("Digite quatro números inteiros:");

            for (int i = 0; i < valores.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out valores[i]))
                {
                    Console.WriteLine("Valor inválido. Digite um número inteiro:");
                }
            }

            Console.WriteLine("Você digitou os valores:");

            foreach (var item in valores)
            {
                Console.Write($" {item}\n");
            }


            int ocorrenciasDoNove = valores.Count(x => x == 9);
            Console.WriteLine($"O valor 9 apareceu {ocorrenciasDoNove} vezes");

            int indiceDoTres = Array.IndexOf(valores, 3);
            if (indiceDoTres != -1)
            {
                Console.WriteLine($"O valor 3 apareceu na posição {indiceDoTres + 1}");
            }
            else
            {
                Console.WriteLine("O valor 3 não foi encontrado na lista.");
            }


            //procurar os números pares da lista
            Console.WriteLine("Os valores pares são");
            foreach (var item in valores)
            {
                if (item %2==0)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}