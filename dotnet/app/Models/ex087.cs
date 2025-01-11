using System;

namespace app.Models
{
    public class ex087
    {
        public void MaisSobreMatrizes()
        {
            // matrix 3 por 3 --> [ [],[],[] ]
            int[,] matriz = new int[3, 3];
            int spar = 0, mai = 0, scol = 0;

            // Preenchendo a matriz
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Digite um valor: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            // Exibindo a matriz e somando os valores pares
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"[{matriz[l, c],5}]");
                    if (matriz[l, c] % 2 == 0)
                    {
                        spar += matriz[l, c];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"A Soma dos Valores pares é {spar}");

            // Somando os valores da terceira coluna
            for (int l = 0; l < 3; l++)
            {
                scol += matriz[l, 2]; // Correto: usando colchetes para matriz 2D
            }

            Console.WriteLine($"A soma dos Valores da terceira coluna é {scol}");

            // Procurar o maior valor da segunda linha
            mai = matriz[1, 0]; // Inicializando o maior valor com o primeiro elemento da segunda linha

            for (int c = 1; c < 3; c++) // Começando a partir do segundo elemento
            {
                if (matriz[1, c] > mai)
                {
                    mai = matriz[1, c];
                }
            }

            Console.WriteLine($"O maior valor da segunda linha é {mai}");
        }
    }
}
