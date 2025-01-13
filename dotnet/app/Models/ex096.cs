
namespace app.Models
{
    public class ex096
    {
        //programa principal
        public void FuncaoQueCalculaArea()
        {
            Console.WriteLine(" CONTROLE DE TERRENOS ");

            Console.WriteLine("Largura");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Comprimento");
            double c = double.Parse(Console.ReadLine());

            //chamando a função
            Area(l, c);

        }


        //funçao
        static void Area(double largura, double comprimento)
        {
            double a = largura * comprimento;
            Console.WriteLine($"A área de um terreno de {largura}X{comprimento} é de {a}M");
        }
    }
}