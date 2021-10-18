using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpsMasterAssigments
{
    class Palindrom_10_14
    {
        // string of array declaration
        string[] strings = new string[10];

        public Palindrom_10_14()
        {
            Console.WriteLine("-----Enter 10 strings-----");
            for(int x = 0; x < 10; x++)
            {
                Console.Write("String {0}: ", x+1);
                strings[x] = Console.ReadLine();
                Console.WriteLine();
            }


        }


        public void printPalindromString()
        {
            Console.WriteLine("-----Output-----");
            // iterate to each item in the array
            foreach (string toCheck in strings)
            {
                string revers = string.Empty;
                // check string backward and assign it to temp variable
                for (int i = toCheck.Length - 1; i >= 0; i--)
                {
                    revers += toCheck[i].ToString();
                }
                // checker if the string backward same as original string
                if (revers == toCheck)
                {
                    Console.WriteLine(toCheck);
                }
            }
        }
    }
}
