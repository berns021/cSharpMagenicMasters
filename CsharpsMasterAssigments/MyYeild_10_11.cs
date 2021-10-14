using System;

namespace CsharpsMasterAssigments
{
    // source : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield
    public class MyYeild_10_11
    {
        /// <summary>
        /// When you use the yield contextual keyword in a statement, 
        /// ou indicate that the method, operator, or get accessor in 
        /// which it appears is an iterator. Using yield to define an 
        /// iterator removes the need for an explicit extra class 
        /// (the class that holds the state for an enumeration, see IEnumerator<T> for an example) 
        /// when you implement the IEnumerable and IEnumerator pattern for a custom collection type.
        /// </summary>
        public MyYeild_10_11()
        {
        }

        public  System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                // The use of  a yield return statement to return each element one at a time
                yield return result;
            }
        }

        // Output: 2 4 8 16 32 64 128 256
    }

}