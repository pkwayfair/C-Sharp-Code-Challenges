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
    }
}
