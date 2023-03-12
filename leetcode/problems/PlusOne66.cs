using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    internal class PlusOne66
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                if (digits[i] > 9) digits[i] = 0;
                else return digits;
            }
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            Array.Copy(digits, 0, result, 1, digits.Length);
            return result;
        }
    }
}
