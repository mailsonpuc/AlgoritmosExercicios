
namespace app.Models
{
    public class ex084
    {
        public void ListaCompletaEanaliseDeDados()
        {
            List<List<object>> princ = new List<List<object>>();
            List<object> temp = new List<object>();
            double mai = 0, men = 0;


            while (true)
            {
                Console.Write("Nome: ");
                temp.Add(Console.ReadLine());
                Console.Write("Peso: ");
                temp.Add(Convert.ToDouble(Console.ReadLine()));

                if (princ.Count == 0)
                {
                    mai = men = (double)temp[1];
                }
                else
                {
                    if ((double)temp[1] > mai)
                    {
                        mai = (double)temp[1];
                    }

                    if ((double)temp[1] < men)
                    {
                        men = (double)temp[1];
                    }
                }

                princ.Add(new List<object>(temp));
                temp.Clear();

                Console.Write("Quer Continuar [S/N]: ");
                string resp = Console.ReadLine();
                if (resp.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }




            Console.WriteLine("Os dados foram");
            foreach (var item in princ)
            {
                Console.WriteLine(item);

            }


            Console.WriteLine($"Ao todo, voce cadastrou {princ.Count} pessoas");
            Console.WriteLine($"O maior peso foi de {mai} KG");


            foreach (var p in princ)
            {
                if ((double)p[1] == mai)
                {
                    Console.WriteLine($"{p[0]}");
                }
            }

            Console.WriteLine($"O menor peso foi de {men} KL");



        }
    }
}