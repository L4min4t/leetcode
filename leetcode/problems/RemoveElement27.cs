using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    internal class RemoveElement27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int counter = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }
            return counter;
        }

    }
}
