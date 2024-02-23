using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo
{
    public static class Utils
    {
        public static List<int> GeneratePrimeNumbers(int target)
        {
            List<int> result = new List<int>();
            int i = 1;
            while(i <= target) {
                if (i == 1)
                {
                    result.Add(i);
                } 
                else
                {
                    int counter = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i%j == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter <=1) { result.Add(i); }
                }
                i += 1;
            }
            return result;
        }

        public static List<int> GenerateFibSeries(int target)
        {
            List<int> result = new List<int>();
            int firstNumber = 1, secondNumber = 2;
            result.Add(firstNumber);
            result.Add(secondNumber);
            for (int i=0;i< target; i++)
            {
                var x = firstNumber + secondNumber;
                result.Add(x);
                firstNumber = secondNumber;
                secondNumber = x;
            }
            return result;
        }
    }
}
