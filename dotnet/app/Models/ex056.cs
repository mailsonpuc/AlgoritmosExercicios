
namespace app.Models
{
    public class ex056
    {
        public void AnalisadorCompleto()
        {
            //-------------------------------------------
            int somaidade = 0;
            double mediaidade = 0;
            int maiorIdadeHome = 0;
            string nomeMaisVelhor = "";
            int totmulher20 = 0;
            //-------------------------------------------


            for (int p = 1; p <= 2; p++)
            {
                Console.WriteLine($"----------Nome da {p} Pessoa------------");
                string nome = Console.ReadLine().Trim().ToUpper();

                Console.WriteLine($"Idade {p} Pessoa");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine($"Sexo [M/F]");
                string sexo = Console.ReadLine().Trim().ToUpper();

                somaidade += idade;

                if (p == 1 && sexo == "M")
                {
                    maiorIdadeHome = idade;
                    nomeMaisVelhor = nome;
                }
                if (sexo == "M" && idade > maiorIdadeHome)
                {
                    maiorIdadeHome = idade;
                    nomeMaisVelhor = nome;
                }
                if (sexo == "F" && idade < 20)
                {
                    totmulher20 += 1;
                }

            }

            mediaidade = somaidade / 4;

            Console.WriteLine($"A Média de idade do grupo é de {mediaidade} anos");
            Console.WriteLine($"O homem mais velho tem {maiorIdadeHome}, e se chama {nomeMaisVelhor}");
            Console.WriteLine($"Ao todo são {totmulher20} mulheres com menos de 20 anos");
        }
    }
}