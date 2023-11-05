namespace ConsoleApp1
{
    public class _347TopKFrequent_Elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            SortedList<int, int> map = new();
            for(int i = 0; i < nums.Length;i++) 
            {
                if (map.ContainsKey(nums[i])) 
                    map[nums[i]]++;
                else
                    map.Add(nums[i], 1);
            }
            int[] res = new int[k];
            IEnumerable<KeyValuePair<int,int>> aux = map.Take(k);
            int j = 0;
            while (j<k)
            {
                res[j] = aux.ElementAt(j).Key;
                j++;
            }
            return res;
        }
    }
}
