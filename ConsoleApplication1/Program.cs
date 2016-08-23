using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is:");


            int answer = 0;
        
            for (int i = 1; i < 1000; i++)
            {
                 if (i % 3 == 0 || i % 5 == 0)
                 {
                    answer = answer + i;
                 }
            }

            Console.WriteLine(answer);


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
