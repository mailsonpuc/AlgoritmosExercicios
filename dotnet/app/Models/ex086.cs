

namespace app.Models
{
    public class ex086
    {
        public void MatrizEmCsharp()
        {

            int[,] matriz = new int[3, 3];

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Digite um valor: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }


            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"[{matriz[l, c],5}]");
                }
                Console.WriteLine();
            }



        }
    }
}