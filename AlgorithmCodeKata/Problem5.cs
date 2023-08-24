using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//자연수 n이 매개변수로 주어집니다. n을 x로 나눈 나머지가 1이 되도록 하는 가장 작은 자연수 x를 return 하도록 solution 함수를 완성해주세요.
//답이 항상 존재함은 증명될 수 있습니다.
namespace AlgorithmCodeKata
{
    internal class Problem5
    {
        public int solution(int n)
        {
            //내 풀이
            int answer = 0;
            n -= 1;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer = i;
                    break;
                }
            }
            return answer;


            //다른 사람 풀이
            //int answer = 1;

            //while (n % answer != 1)
            //{
            //    answer++;
            //}
            //return answer;
        }

    }
}
