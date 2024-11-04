using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ex001
    {
        public string? Frase { get; set; }

        public void Falar()
        {
            Console.WriteLine($"voce disse {Frase}");
        }

    }
}