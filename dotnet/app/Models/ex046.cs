using System;
using System.Collections.Generic;
using System.Linq;

namespace app.Models
{
    public class ex046
    {
        public void Contagem()
        {
            for (int num = 10; num >= 0; num--)
            {
                Console.WriteLine(num);
                Thread.Sleep(100);
            }
            
            Console.WriteLine("BUM BUM POOW");

        }
    }
}