
namespace app.Models
{
    public class ex103
    {
        //programa principal
        public void FuncaoParOuImpar()
        {
            Console.WriteLine(ParOuImpar(10));
            Console.WriteLine(ParOuImpar(3));
            Console.WriteLine(ParOuImpar(DateTime.Now.Year));
        }


        public object ParOuImpar(int num)
        {
            string resultado = (num % 2 == 0) ? $"O Número {num} é PAR" : $"O Número {num} é IMPAR";
            return resultado;
        }



    }
}