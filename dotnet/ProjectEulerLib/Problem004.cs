using System;
using static System.Console;


namespace ProjectEulerLib
{
    public class Problem004
    {
        public int results = 0;
        public int lastBigger = 0;
        public void SolveProblem()
        {
            int start = 100;
            int limit = 999;
            
            for (int i = start; i <= limit; i++)
            {
                for (int y = start; y <= limit; y++)
                {
                    int result = i * y;
                    //WriteLine($"{i} * {y} = {result}");
                    CheckoppositeChars(result, i, y);
                }
            }
            WriteLine($" The bigger number is: {lastBigger}");

        }
        public void CheckoppositeChars(int currentNumber, int first, int second)
        {
            string stringToCheck = currentNumber.ToString();
            int tempLength = stringToCheck.Length;
            int loops = tempLength / 2;
            string lastString = stringToCheck;
            int lastTemp = 0;
            for (int i = 0; i < loops ; i++)
            {
                int firstChar = lastString[i];
                int secondChar = lastString[tempLength - 1 - i];
                if (firstChar == secondChar)
                {
                    lastTemp++;
                    if (lastTemp >= 3)
                    {
                        results++;
                        if (currentNumber > lastBigger) lastBigger = currentNumber;
                        WriteLine($"Checking No: {results} == {first} * {second} = {stringToCheck}");
                    }
                }
                else break;
            }
        }
    }
}