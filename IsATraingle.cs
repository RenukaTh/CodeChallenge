using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class IsATraingle
    {

        //int a, b, c;
        public static void Main(String[] args)
        {
            int a = 7, b = 10, c = 5;

            if (checkValidity(a, b, c))
            {
                Console.WriteLine("Valid traingle");
            }
            else
                Console.WriteLine("Invalid triangle");

        }


        static Boolean checkValidity(int a, int b, int c)
        {
            // check condition 
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }
    }
}
