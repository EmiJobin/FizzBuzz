using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  print number starting from 1 to 100. When a number is multiple of three, print “Fizz” instead of a number on the console and if multiple of five then print “Buzz” on the console. For numbers which are multiple of three as well five, print “FizzBuzz” on the console.*/

            for(int i = 1; i <= 100; i++)
            {
               if( i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
               else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("Fizz Buzz");
                }
            }







            Console.ReadKey();
        }
    }
}
