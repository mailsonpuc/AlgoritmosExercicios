namespace app.Models
{
    public class ex068
    {
        public void JogoDoParOuImopar()
        {
            Random computador = new Random();
            int v = 0;


            while (true)
            {
                Console.WriteLine("DIga um valor");
                int jogador = int.Parse(Console.ReadLine());

                int cpt = computador.Next(0, 11);
                int total = jogador + cpt;
                string tipo = "";

                while (tipo == "p" || tipo == "P" || tipo == "i" || tipo == "I")
                {
                    Console.WriteLine("PAR OU IMPAR? [p/i]");
                    tipo = Console.ReadLine().Trim();

                }

                Console.WriteLine($"Voce jogou {jogador} e o computador {cpt}, total de {total}");

                if (tipo == "P")
                {
                    if (total %2 ==0)
                    {
                        Console.WriteLine("Voce venceu");
                        v+=1;
                    }
                    else
                    {
                        Console.WriteLine("Voce perdeu");
                        break;
                    }
                }
                else if (tipo == "I")
                {
                    if (total %2==1)
                    {
                        Console.WriteLine("Voce venceu");
                        v +=1;
                    }
                    else
                    {
                        Console.WriteLine("Voce perdeu");
                        break;
                    }
                    
                }


            Console.WriteLine("Vamos jogar novamente...");
            }

            Console.WriteLine($"GAME OVE, Voce venceu com {v} vezes");
        }
    }
}