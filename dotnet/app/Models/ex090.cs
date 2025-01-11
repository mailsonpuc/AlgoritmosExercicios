using System.Collections.Generic;


namespace app.Models
{
    public class ex090
    {
        public void DicionarioEmCshsarp()
        {

            Dictionary<string, object> aluno = new Dictionary<string, object>();

            Console.Write("Nome: ");
            aluno["nome"] = Console.ReadLine();

            Console.Write("Media: ");
            aluno["media"] = double.Parse(Console.ReadLine());


            // Convertendo o valor de "media" para double antes de comparar
            double media = (double)aluno["media"];


            // Verificando a situação do aluno
            if (media >= 7)
            {
                aluno["situacao"] = "Aprovado";
            }
            else if (media <= 5 || media < 7)
            {
                aluno["situacao"] = "Recuperação";
            }
            else
            {
                aluno["situacao"] = "Reprovado";
            }


            // // Exibindo os dados do aluno
            // Console.WriteLine("\n--- Dados do Aluno ---");
            // Console.WriteLine($"Nome: {aluno["nome"]}");
            // Console.WriteLine($"Média: {aluno["media"]}");
            // Console.WriteLine($"Situação: {aluno["situacao"]}");


            foreach (KeyValuePair<string, object> item in aluno)
            {
                //Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
                Console.WriteLine($"{item.Key} é igual a  {item.Value}");
            }


        }
    }
}