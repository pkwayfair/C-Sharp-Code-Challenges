using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemo
{
    public class DuplicateOccurrencesInArray
    {
        public Dictionary<int,int> CountOccurrences(int[] array)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for(int i = 0; i < array.Length; i++)
            {
                if (result.ContainsKey(array[i]))
                {
                    result[array[i]]++;
                } else
                {
                    result.Add(array[i], 1);
                }
            }
            return result;
        }
    }
}
