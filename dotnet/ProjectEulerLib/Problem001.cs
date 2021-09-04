using System;
using static System.Console;

namespace ProjectEulerLib
{
    public class Problem001
    {
        /*
            If we list all the natural number below 10 that are multiples of 3 or 5, we get 3, 5, 6, and 9. The sum of these multiples is 23
            Find the sum of all multiples of 3 or 5 below 1000.
        */

        int finalSum;
        public void SolveProblem(int length = 1000)
        {
            Write("Problem 001 solution: ");
            for (int i = 0; i < length; i++)
            {
                //Write(i + " ");
                if ((i % 3) == 0)
                {
                    finalSum += i;
                }
                else if ((i % 5) == 0)
                {
                    finalSum += i;
                }
            }
            WriteLine($"The sum is {finalSum}");
        }
    }
}
