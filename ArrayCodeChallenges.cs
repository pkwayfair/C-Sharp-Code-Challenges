using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo
{
    public class ArrayCodeChallenges
    {
        public int GetSmallestPositiveInteger(int[] arr)
        {
            int i = 1;
            while (true)
            {
                if (!arr.Contains(i))
                {
                    break;
                }
                i++;
            }
            return i;
        }
    }
}
