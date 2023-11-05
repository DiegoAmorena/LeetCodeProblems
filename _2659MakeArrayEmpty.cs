namespace ConsoleApp1
{
    public class _2659MakeArrayEmpty
    {
        public long CountOperationsToEmptyArray(int[] nums)
        {
            var ordered = new SortedSet<int>();
            int totalRemoved = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ordered.Add(nums[i]);
            }
            int res = 0;
            while (totalRemoved < nums.Length)
            {
                int firstElement = ordered.First();
                while(nums[totalRemoved] != firstElement)
                {
                    ElementAtToLast(nums, totalRemoved);
                    res++;
                }
                totalRemoved++;
                ordered.Remove(firstElement);
                res++;
            }
            return res;
        }

        public int[] ElementAtToLast(int[] nums,int i) 
        {
            int aux = nums[i];
            for (int j = i; j < nums.Length - 1; j++)
                nums[j] = nums[j + 1];
            nums[nums.Length - 1] = aux;
            return nums;
        }

    }
}
