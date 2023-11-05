using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BackTracking
{
    public class _2717SemiOrderedPermutation
    {
        public int MinimunNumberOfNums(int[] permutation)
        {
            int index1 = -1;
            int indexN = -1;
            int i = 0;
            while (index1 == -1 || indexN == -1)
            {
                if (permutation[i] == 1)
                    index1 = i;
                else if (permutation[i] == permutation.Length)
                    indexN = i;
                i++;
            }
            return index1 > indexN ? index1 + (permutation.Length - 2 - indexN) : index1 + (permutation.Length - 1 - indexN);
        }
    }
}
