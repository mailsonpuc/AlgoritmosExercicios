
namespace app.Models
{
    public class ex094
    {
        public void UnindoDicionarioElista()
        {


            List<Dictionary<string, object>> galera = new List<Dictionary<string, object>>();
            Dictionary<string, object> pessoa;



            while (true)
            {
                pessoa = new Dictionary<string, object>();
                Console.Write("Nome: ");
                pessoa["nome"] = Console.ReadLine();

                while (true)
                {
                    Console.Write("Sexo: [M/F]? ");
                    pessoa["sexo"] = Console.ReadLine().ToUpper();
                    if (pessoa["sexo"].ToString() == "M" || pessoa["sexo"].ToString() == "F")
                    {
                        break;
                    }
                    Console.WriteLine("ERRO Digite Apenas M ou F");
                }

                Console.Write("Idade: ");
                pessoa["idade"] = int.Parse(Console.ReadLine());
                galera.Add(new Dictionary<string, object>(pessoa));

                while (true)
                {
                    Console.Write("Quer continuar? [S/N] ");
                    string resp = Console.ReadLine().ToUpper();
                    if (resp == "S" || resp == "N")
                    {
                        if (resp == "N")
                        {
                            return;
                        }
                        break;
                    }
                    Console.WriteLine("Erro responda apenas S ou N");
                }
            }



            foreach (var item in galera)
            {
                Console.WriteLine(string.Join(", ", item));
            }


        }
    }
}