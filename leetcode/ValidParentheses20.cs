using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class ValidParentheses20
    {
        public bool IsValid(string s)
        {
            if (s.Length == 1) return false;

            string opening = "{([";
            Dictionary<char, char> keyValuePairs = new Dictionary<char, char> 
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };
            Stack<char> stack = new Stack<char>();

            foreach(char c in s) 
            {
                try
                {
                    if (opening.Contains(c)) stack.Push(c);
                    else if (keyValuePairs[stack.Pop()] != c) return false;
                } catch (Exception e)
                {
                    return false;
                }
                
            }

            if (stack.Count == 0) return true;
            return false;
        }
    }
}
