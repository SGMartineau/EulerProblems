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
            


            int answer1 = 0;
        
            for (int i = 1; i < 1000; i++)
            {
                 if (i % 3 == 0 || i % 5 == 0)
                 {
                    answer1 = answer1 + i;
                 }
            }

            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is:");
            Console.WriteLine(answer1);

            int fibAnswer = 2;
            int fib1 = 1;
            int fib2 = 2;
            
            while (fib1 + fib2 < 4000000)
            {
                int fibs = fib1 + fib2;
                if (fibs % 2 == 0)
                {
                    fibAnswer = fibAnswer + fibs;
                }
                fib1 = fib2;
                fib2 = fibs;
            }

            Console.WriteLine("The sum of the even-valued terms in the Fibonacci sequence whose values do not exceed four million is:");
            Console.WriteLine(fibAnswer);



            const long huge = 600851475143;
            long factAnswer = 0;
            long reduce = huge;

            for (long i = 2; i < reduce; i++)
            {
                while (reduce % i == 0)
                {
                    reduce = reduce / i;
                    factAnswer = i;
                }
            }
            if (reduce > factAnswer)
            {
                factAnswer = reduce;
            }

            Console.WriteLine("The largest prime factor of the number 600851475143 is:");
            Console.WriteLine(factAnswer);
            


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
