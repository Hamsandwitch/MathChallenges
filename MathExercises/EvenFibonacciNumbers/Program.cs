using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Even Fibonacci Numbers");
            Console.WriteLine("`````````````````````````");

            var num1 = 0;
            var num2 = 1;
            var num3 = 0;
            var num4 = 0;


            for(x = 0;  num2 <= 4000000; x++)
            {
            
                var c = num1;
                num1 = num2;
                num2 = c + num1;
                
            }

            if (num2 % 2 == 0 && num2 < 4000000)
            {

                var num3 = num2 += num2;




                //num4 = num2 + num3;
                //num3 = num4;
            };

                Console.WriteLine(num3);

            Console.ReadLine();

        }

    }
}
