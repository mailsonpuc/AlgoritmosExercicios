namespace app.Models
{
    public class ex069
    {
        public void AnaliseDeDadosDeGrupo()
        {
            int tot18 =0;
            int totH = 0;
            int totM20 = 0;

            while (true)
            {
                Console.WriteLine("Idade");
                int idade = int.Parse(Console.ReadLine());

                string sexo = "";

                while (sexo != "M" && sexo != "F")
                {
                    Console.WriteLine("Sexo [M/F]");
                    sexo = Console.ReadLine().Trim().ToUpper();
                }

                if (idade >=18)
                {
                    tot18 +=1;
                }

                if (sexo == "M")
                {
                    totH+=1;   
                }

                if (sexo == "F" && idade < 20)
                {
                    totM20 +=1;   
                }








                string resp = "";

                while (resp != "S" && resp != "N")
                {
                    Console.WriteLine("Quer continuar? [S/N]");
                    resp = Console.ReadLine().Trim().ToUpper();
                }
                if (resp == "N")
                    break;

            }
            Console.WriteLine($"Total de pessoas com mais de 18 anos: {tot18}");
            Console.WriteLine($"Ao todo temos {totH} homens cadastrados");
            Console.WriteLine($"E temos {totM20} Mulheres com menos de 18 anos");
        }
    }
}