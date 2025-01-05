using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex057
    {
        public void ValidacaoDeDados()
        {
            Console.WriteLine("Digite Seu Sexo [M/F]");
            string sexo = Console.ReadLine().ToUpper().Trim();

            while (sexo != "M" && sexo != "F")
            {
                Console.WriteLine("Dados invalidos. Por favor, informe seu sexo: ");
                sexo = Console.ReadLine().Trim().ToUpper();
            }
            Console.WriteLine($"Sexo {sexo} registrado com sucesso");


        }
    }
}