namespace app.Models
{
    public class ex088
    {
        public void JogarNaMegaSena()
        {
            Random num = new Random();

            List<List<int>> todosJogos = new List<List<int>>(); // Lista para armazenar todos os jogos

            Console.WriteLine("-".PadLeft(60, '-'));
            Console.WriteLine("JOGA NA MEGA SENA".ToUpper());
            Console.WriteLine("-".PadLeft(60, '-'));

            Console.WriteLine("Quantos jogos você quer que eu sorteie?");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                List<int> jogo = new List<int>();

                while (jogo.Count < 6)
                {
                    int n = num.Next(1, 61);
                    if (!jogo.Contains(n))
                    {
                        jogo.Add(n);
                    }
                }

                jogo.Sort();
                todosJogos.Add(jogo);
            }

            // Exibir todos os jogos
            for (int i = 0; i < todosJogos.Count; i++)
            {
                Console.WriteLine($"Jogo {i + 1}: {string.Join(", ", todosJogos[i])}");
                Thread.Sleep(1000);
            }
        }
    }
}