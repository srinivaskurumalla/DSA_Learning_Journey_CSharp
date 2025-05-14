using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.Arrays.Problems
{
    internal class ArrayCoding
    {
        public int FindMax(int[] nums)
        {
            int max = nums[0];
            foreach (int item in nums)  //O(n)
            {
                if (item > max) max = item;
            }
            return max;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>(nums); //O(n)
            return result.Count != nums.Length;
        }

        public int LongestSubarraySumEqualsK(int[] nums, int k)
        {
            int maxLength = 0;

            for (int start = 0; start < nums.Length; start++)
            {
                int sum = 0;

                for (int end = start; end < nums.Length; end++)
                {
                    sum += nums[end];

                    if (sum == k)
                    {
                        maxLength = Math.Max(maxLength, end - start + 1);
                    }
                }
            }

            return maxLength;
        }

        public int LongestSubarraySumEqualsK2(int[] nums, int k)
        {
            int maxLength = 0;
            int sum = 0;
            Dictionary<int,int> dict = new Dictionary<int,int>();
            dict[0] = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if(dict.ContainsKey(sum-k))
                {
                    maxLength = Math.Max(maxLength, i - dict[sum-k]);
                }


                // Store only the first occurrence of this prefix sum
                if (!dict.ContainsKey(sum))
                {
                    dict[sum] = i;
                }
            }
            return maxLength;
        }

    }
}
