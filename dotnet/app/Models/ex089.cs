namespace app.Models
{
    public class ex089
    {
        public void BoletimComLista()
        {


            List<object> ficha = new List<object>();

            while (true)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Nota1: ");
                float nota1 = float.Parse(Console.ReadLine());

                Console.Write("Nota2: ");
                float nota2 = float.Parse(Console.ReadLine());

                float media = (nota1 + nota2) / 2;

                ficha.Add(new object[] { nome, new float[] { nota1, nota2 }, media });

                Console.WriteLine("Quer Continuar? [S/N]");
                string resp = Console.ReadLine().ToUpper().Trim();

                if (resp == "N")
                {
                    break;

                }

                // Iterar sobre os itens da lista "ficha"

            }


            Console.WriteLine("-".PadLeft(40, '-'));

            foreach (var item in ficha)
            {
                // Verificar se o item é um array de objetos
                if (item is object[] arr)
                {
                    // Exibir o nome
                    string nomeAluno = (string)arr[0];
                    // Exibir as notas
                    float[] notas = (float[])arr[1];
                    // Exibir a média
                    float mediaAluno = (float)arr[2];

                    Console.WriteLine($"Nome: {nomeAluno}");
                    Console.WriteLine($"Nota 1: {notas[0]}, Nota 2: {notas[1]}");
                    Console.WriteLine($"Média: {mediaAluno}");
                }
            }

            Console.WriteLine("-".PadLeft(40, '-'));


        }
    }
}
