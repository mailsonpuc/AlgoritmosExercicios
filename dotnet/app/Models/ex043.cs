using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex043
    {
        public void CalcularImc()
        {
            Console.Write("Digite seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite sua altura (m): ex: 1,50  ");
            double altura = Convert.ToDouble(Console.ReadLine());

            //double imc = peso / (Math.Sqrt(altura));
            double imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é: {imc:F2}");


            if (imc < 18.5)
                Console.WriteLine("Classificação: Abaixo do peso");
            else if (imc < 24.9)
                Console.WriteLine("Classificação: Peso normal");
            else if (imc < 29.9)
                Console.WriteLine("Classificação: Sobrepeso");
            else if (imc < 34.9)
                Console.WriteLine("Classificação: Obesidade Grau I");
            else if (imc < 39.9)
                Console.WriteLine("Classificação: Obesidade Grau II");
            else
                Console.WriteLine("Classificação: Obesidade Grau III (mórbida)");


        }
    }
}