using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class Problem8
    {
        static public int solution(string s)
        {
            int num;
            if (s[0] == '-' || s[0] == '+')
            {
                num = int.Parse(s.Substring(1, s.Length - 1));
                if (s[0] == '-') num *= (-1);
            }
            else
            {
                num = int.Parse(s);
            }
            return num;
        }
    }
}
