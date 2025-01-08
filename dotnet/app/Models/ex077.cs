
namespace app.Models
{
    public class ex077
    {
        public void ContandoVogais()
        {


            Console.WriteLine("-".PadLeft(20, '-'));
            Console.WriteLine("COntador de vogais".ToUpper());
            Console.WriteLine("-".PadLeft(20, '-'));


            List<string> palavras =
             [
              "Lapis","Borracha","Caderno","Estojo","Transferidor",
              "Compasso","Mochila","Canetas","Livro"
             ];

            foreach (var item in palavras)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\nNa palavra {item.ToUpper()} Temos:");
                Console.ResetColor();

                foreach (var letra in item.ToLower())
                {
                    if ("aeiou".Contains(letra))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($" {letra} ");
                        Console.ResetColor();
                    }

                }

            }
            Console.WriteLine();


        }
    }
}
