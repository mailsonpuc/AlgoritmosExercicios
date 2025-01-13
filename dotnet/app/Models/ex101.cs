

namespace app.Models
{
    public class ex101
    {
        //programa principal
        public void funcaoParaVotacao()
        {
            // Console.WriteLine(voto(1997));
            // Console.WriteLine(voto(1900));
            // Console.WriteLine(voto(2020));
            
            Console.WriteLine("-".PadLeft(40,'-'));
            Console.WriteLine("Em que ano você nasceu?");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine(voto(nascimento));
        }


        static object voto(int ano)
        {
            var atual = DateTime.Now.Year;
            int idade = atual - ano;
            if (idade < 16)
            {
                return $"Com {idade} anos: NÂO VOTA";
            }
            else if (idade <= 16 && idade < 18 || idade > 65)
            {
                return $"Com {idade} anos: VOTO OPCIONAL";
            }
            else
            {
                return $"Com {idade} anos: VOTO OBRIGATORIO";
            }


        }

    }
}