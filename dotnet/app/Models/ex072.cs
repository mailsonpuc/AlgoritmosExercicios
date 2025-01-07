namespace app.Models
{
    public class ex072
    {
        public void NumeroPorExtenso()
        {
            // em uma lista
            var cont = new string[] {"zero", "um", "dois", "três", "quatro", "cinco", "seis",
            "sete", "oito", "nove", "dez", "onze", "doze", "treze", "catorze", "quinze",
            "dezesseis", "dezessete", "dezoito", "dezenove", "vinte"};

            while (true)
            {
                Console.WriteLine("Digite um número entre 0 e 20");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num >= 0 && num <= 20)
                    {
                        Console.WriteLine($"Você digitou o número {cont[num]}");
                        Console.WriteLine("Quer continuar? [S/N]");
                        string continua = Console.ReadLine().ToUpper().Trim();
                        if (continua == "S")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                            break;
                    }
                }
                Console.WriteLine("Número inválido! Tente novamente.");
            }
        }
    }
}