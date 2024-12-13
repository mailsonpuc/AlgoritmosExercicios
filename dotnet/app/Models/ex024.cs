using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex024
    {
        public  bool VerificarPalavra()
        {
            Console.WriteLine("Em que cidade voce nasceu?");
            
            string p = Console.ReadLine().Trim().ToLower();
            if(p.StartsWith("santo"))
                return true;
            return false;

            

        }
    }
}