
namespace app.Models
{
    public class ex104
    {
        //crie um programa que tenha a funcao leiaInt(), 
        //que vai funcionar de forma semelhante á função 
        //input do python, so que fazendo a validação
        //para aceita apenas um número

        //programa principal
        public void funcaoLeiaint()
        {
            int n = LeiaInt("Digite um numero: ");
            Console.WriteLine($"Voce Acabou de digitar o numero {n}");
        }




        static int LeiaInt(string msg)
        {
            bool ok = false;
            int valor = 0;

            while (true)
            {
                Console.Write(msg);
                string n = Console.ReadLine();
                if (int.TryParse(n, out valor))
                {
                    ok = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erro digite um numero valido");
                    Console.ResetColor();
                }

                if (ok)
                {
                    break;
                }
            }
            return valor;
        }


    }
}