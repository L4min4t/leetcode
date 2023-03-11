using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    internal class RemoveDuplicatesFromSortedArray26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int index = 0;
            for(int i=1; i < nums.Length; i++)
            {
                if (nums[i] != nums[index])
                {
                    index++;
                    nums[index] = nums[i];
                }
            }
            return ++index;
        }
    }
}
