namespace app.Models
{
    public class ex066
    {
        public void VariosNumerosComFlag()
        {
            int num = 0;
            int soma = 0;
            int cont = 0;


            while (true)
            {
                Console.WriteLine("Digite um valor [999] para parar");
                num = int.Parse(Console.ReadLine());

                if (num == 999)
                    break;
                
                //conta
                cont += 1;
                //soma
                soma += num;
            }

            Console.WriteLine($"A soma dos valores {cont} valores foi {soma}!");
           


        }
    }
}