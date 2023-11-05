using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class _20ValidParenthesis
    {
        private Stack<Char> _stack = new();

        public bool IsValid(string s)
        {
            for(int i = 0; i < s.Length;i++) 
            {
                if (!IsValid(s[i]))
                    return false;
            }
            return _stack.Count == 0;
        }
        private bool IsValid(char v)
        {
            switch (v) 
            {
                case '(':
                    _stack.Push('(');
                    return true;
                case '[':
                    _stack.Push('[');
                    return true;
                case '{':
                    _stack.Push('{');
                    return true;
                case '}':
                    return _stack.Count > 0 && '{' == _stack.Pop();
                case ']':
                    return _stack.Count > 0 && '[' == _stack.Pop();
                case ')':
                    return _stack.Count > 0 && '(' == _stack.Pop();
                default: return false;
            }
        }
    }
}
