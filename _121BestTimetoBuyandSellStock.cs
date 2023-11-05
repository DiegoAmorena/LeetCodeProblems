using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class _121BestTimetoBuyandSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int[,] helper = new int[prices.Length, prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                helper[i, i] = 0;
            }
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    helper[i, j] = helper[i, j - 1] > prices[j] - prices[i] ? helper[i, j - 1] : prices[j] - prices[i];
                }
            }
            return helper[0, prices.Length - 1];
        }

    }
}
