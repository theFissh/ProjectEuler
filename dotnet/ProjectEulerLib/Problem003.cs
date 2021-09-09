using System;
using static System.Console;




namespace ProjectEulerLib
{
    public class Problem003
    {
        /*
            Largest prime factor
            The prime factors of 13195 are 5,7,13 and 29
            What is the largest prime factor of the number 600851475143 ?
        */

        public void SolveProblem()
        {
            long number = 600851475143;
            long module = 0;
            do
            {
                number %= 2;
                WriteLine(number);
                module = number / number;
                WriteLine(module);
            }
            while (module != 1);
        }
    }
}