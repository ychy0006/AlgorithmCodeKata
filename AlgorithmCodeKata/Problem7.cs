using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCodeKata
{
    internal class Problem7
    {
        static public int[] solution(long n)
        {
            long a = n;
            int i = 0;
            while (a > 0)
            {
                a /= 10;
                i++;
            }
            a = n;
            int[] answer = new int[i];
            for (int j = 0; j < i; j++)
            {
                long ans = a % 10; // 자동 형변환
                answer[j] = (int)ans; // 명시적 형변환해줘야함
                a /= 10;
            }
            return answer;
        }
    }
}
