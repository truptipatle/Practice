using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Session
{
    class Program
    {
        int sum(float a, float b)
        {

            return 1 ;
        }

        double sum(int a, float b)
        {
            //char A = 'a';
            //int B = A;

            return  a + b;

        }


        double sum(int a, long b, int c)
        {
            return 1;
        }

         int sum(long a, long b)
        {
            return 1;
        }

        public static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.sum(12.7f, 45.9f));
            Console.WriteLine(p.sum(12, 45.9f));

            // Cannot convert from double to float
          //  Console.WriteLine(p.sum(12.235654, 45.92456));

         // Console.WriteLine(p.sum(12, 44.98, 29));



            Console.ReadLine();

        }


    }
}

