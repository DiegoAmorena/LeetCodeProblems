using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class _217ContainsDuplicate
    {
        public HashSet<int>  helper= new ();
        public bool ContainsDuplicate(int[] nums)
        {
            foreach (int i in nums)
                if (helper.Contains(i))
                    return true;
                else 
                    helper.Add(i);

            return false;
        }
    }
}
