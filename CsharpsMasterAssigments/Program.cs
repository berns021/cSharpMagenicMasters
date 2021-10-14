using System;

namespace CsharpsMasterAssigments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assigment 1");
            MyYeild_10_11 assigment1 = new MyYeild_10_11();
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in assigment1.Power(2, 8))
            {
                // this will prnt the return value from the yield statement 
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n--------------End of assigment 1------------------");

            Console.WriteLine("Assigment 2");
            Palindrom_10_14 palindrom_10_14 = new Palindrom_10_14();
            palindrom_10_14.printPalindromString();
            Console.WriteLine("--------------End of assigment 2------------------");




            Console.ReadKey();
        }
    }
}
