using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class LongestCommonPrefix14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            string result = string.Empty;
            int flag = 0;

            try
            {
                for (int i = 0; i < strs[0].Length; i++)
                {
                    foreach(string str in strs)
                    {
                        if (strs[0][i] == str[i]) flag++;
                    }
                    if (flag == strs.Length)
                    {
                        result += strs[0][i];
                        flag = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                return result;
            }
            return result;

        }
    }
}
