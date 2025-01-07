
namespace app.Models
{
    public class ex071
    {
        public void SimuladorDeCaixaEletronico()
        {
            Console.WriteLine("-------------------banco cev-------------------".ToUpper());
            Console.WriteLine("Quanto valor voce quer sacar? R$");
            int valor = int.Parse(Console.ReadLine());
            int total = valor;
            int ced = 50;
            int totced = 0;
            while (true)
            {
                if (total >= ced)
                {
                    total -= ced;
                    totced += 1;
                }
                else
                {
                    Console.WriteLine($"Total de {totced} cédulas de R${ced}");
                    if (ced == 50)
                    {
                        ced = 20;
                    }
                    else if (ced == 20)
                    {
                        ced = 10;

                    }
                    else if (ced == 10)
                    {
                        ced = 1;

                    }
                    totced=0;
                    if (total == 0)
                    {
                        break;
                    }


                }

            }





        }
    }
}