using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpsMasterAssigments
{
    class Palindrom_10_14
    {
        // string of array declaration
        string[] strings = new string[]
        {
            "ooooo",
            "refth",
            "qwqwq",
            "uuuuu"

        };

        public Palindrom_10_14()
        {
            // iterate to each item in the array
            foreach(string toCheck in strings)
            {
                string revers = string.Empty;
                // check string backward and assign it to temp variable
                for (int i = toCheck.Length - 1; i >= 0; i--) 
                {
                    revers += toCheck[i].ToString();
                }
                // checker if the string backward same as original string
                if(revers == toCheck)
                {
                    Console.WriteLine(toCheck);
                }
            }

        }


        public void printPalindromString()
        {

        }
    }
}
