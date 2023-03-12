using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    internal class LengthOfLastWord58
    {
        public int LengthOfLastWord(string s)
        {
            int counter = 0;
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(s[i])) counter++;
                else if (counter > 0) return counter;
            }
            return s.Trim().Length;
        }
    }
}
