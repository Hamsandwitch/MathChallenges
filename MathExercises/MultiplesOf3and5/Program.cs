using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3and5
{
    public class Program
    {

        static void Main(string[] args)
        {
            var x = 0;
            var i = 0; 

            for (i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    x += i;
                    
                }

                else if (i % 5 == 0)
                {
                    x += i;

                }

            Console.WriteLine(x);
            }
            
            Console.ReadLine();


        }
    }
}
