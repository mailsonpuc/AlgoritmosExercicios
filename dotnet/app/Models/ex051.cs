namespace app.Models
{
    public class ex051
    {
        public void AritmeticaPA()
        {


            try
            {
                Console.WriteLine("Primeiro termo");
                int primeiro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("razão");
                int razao = Convert.ToInt32(Console.ReadLine());

                int decimo = primeiro + (10 - 1) * razao;

                for (int c = primeiro; c <= decimo; c += razao)
                {
                    Console.Write($"{c} ->");
                }

                Console.WriteLine("Acabou");

            }
            catch (System.Exception)
            {
                Console.WriteLine("Ocorreu um Erro, digite apenas Números");
            }





        }

    }
}