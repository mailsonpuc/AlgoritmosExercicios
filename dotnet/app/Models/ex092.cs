

namespace app.Models
{
    public class ex092
    {
        public void CadastroDeTrabalhadorEmCsharp()
        {
            Dictionary<object, object> dados = new Dictionary<object, object>();

            Console.WriteLine("Nome");
            dados["nome"] = Console.ReadLine();

            Console.WriteLine("Ano de Nascimento");
            int nasc = int.Parse(Console.ReadLine());

            DateTime agora = DateTime.Now;
            dados["idade"] = agora.Year - nasc;

            Console.WriteLine("Carteira de Trabalo (0 não tem)");
            dados["ctps"] = int.Parse(Console.ReadLine());


            // Convertendo o valor de "dados["ctps"]" para int antes de comparar
            int ctps = (int)dados["ctps"];

            if (ctps != 0)
            {
                Console.WriteLine("Ano de Contratação");
                dados["contratacao"] = int.Parse(Console.ReadLine());
                Console.WriteLine("Salario R$");
                dados["salario"] = double.Parse(Console.ReadLine());
                dados["aposentadoria"] = (int)dados["idade"] + (((int)dados["contratacao"] + 35) - agora.Year);
            }


            Console.WriteLine("-".PadLeft(40, '-'));

            foreach (var item in dados)
            {
                Console.WriteLine($"{item.Key} --> {item.Value} ");
            }

            Console.WriteLine("-".PadLeft(40, '-'));

        }
    }
}