using System;
using System.Collections;
using System.Collections.Generic;

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
            double number = 600851475143;
            double remainder = number;
            double LastPrimeFactor;
            bool keepLooping = true;
            while (keepLooping)
            {
                Write("Prime factoring the number: " +  remainder);
                (remainder, LastPrimeFactor) = GetResidual(remainder);
                WriteLine(" Prime factor: " + LastPrimeFactor + " Remainder: " + remainder);
                if (remainder <= 1) keepLooping = false;
            }
        }
        (double, double) GetResidual(double last)
        {
            double temp2 = 0;
            double primeFactor = 2;
            for (double i = 2; i <= last; i++)
            {
                double temp = last % i;
                if (temp == 0)
                {
                    temp2 = last / i;
                    primeFactor = i;
                    break;
                }
            }
            return (temp2, primeFactor);
        }
    }
}