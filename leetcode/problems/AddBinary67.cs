using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    internal class AddBinary67
    {
        public string AddBinary(string a, string b)
        {
            int alen = a.Length, blen = b.Length;
            int i = 0, c = 0;
            string ans = "";
            while (i < alen || i < blen || c != 0)
            {
                int x = 0;
                if (i < alen && a[alen - i - 1] == '1') x = 1;

                int y = 0;
                if (i < blen && b[blen - i - 1] == '1') y = 1;

                int sum = x + y + c;
                ans = sum % 2 + ans;
                c = sum / 2;
                i++;
            }
            return ans;
        }
    }
}
