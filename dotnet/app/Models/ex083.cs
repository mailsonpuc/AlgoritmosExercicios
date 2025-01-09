
using System.Linq.Expressions;

namespace app.Models
{
    public class ex083
    {
        public void ValidandoExpresaoNumerica()
        {

            Console.Write("Digite a expressão: ");
            string expr = Console.ReadLine();
            Stack<char> pilha = new Stack<char>();


            foreach (char simb in expr)
            {
                if (simb == '(')
                {
                    pilha.Push('(');
                }
                else if (simb == ')')
                {
                    if (pilha.Count > 0)
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        pilha.Push(')');
                        break;
                    }
                }
            }

            if (pilha.Count == 0)
            {
                Console.WriteLine("Sua expressão esta valida");
            }
            else
            {
                Console.WriteLine("Sua expressão esta errada");
            }
        }

    }
}