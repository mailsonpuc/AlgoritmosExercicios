
namespace app.Models
{
    public class ex097
    {
        //principal
        public void UmPrintEspecial()
        {
            Escreva("Oi Mundo");

            Escreva("Fazendo exercicios em c sharp");

            Escreva("A linha se adapta Ao tamaho da msg");
        }



        //funcao
        static void Escreva(string msg)
        {
            int tamanho = msg.Length;

            Console.WriteLine("-".PadLeft(tamanho, '-'));
            Console.WriteLine(msg);
            Console.WriteLine("-".PadLeft(tamanho, '-'));
        }



    }
}