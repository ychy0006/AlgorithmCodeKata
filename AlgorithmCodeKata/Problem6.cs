using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//함수 solution은 정수 x와 자연수 n을 입력 받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴해야 합니다.
//다음 제한 조건을 보고, 조건을 만족하는 함수, solution을 완성해주세요.
namespace AlgorithmCodeKata
{
    internal class Problem6
    {
        //내 풀이
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            long i = 0; 
            while (i < n)
            {
                answer[i] = x * (++i); 
                //i를 long으로 선언하지 않으면 오버플로우 발생. x와 i를 곱한것은 int형의 크기를 넘을 수도 있기 때문이다.
                //결과값은 long으로 알아서 넣어지지만 계산 중에는 아직 int형이므로 주의할것
                //계산 중에도 오버플로우 발생할 수 있다.
            }
            return answer;
        }

        //다른 사람 풀이1 : i를 int형으로 선언했다면 정말 index로만 쓰고 계산에는 사용안하는 방법도 있다
        //public long[] solution(int x, int n)
        //{
        //    long[] answer = new long[n];

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (i == 0)
        //            answer[i] = x;
        //        else
        //            answer[i] = x + answer[i - 1];
        //    }

        //    return answer;

        //} 

        //다른 사람 풀이2 : i를 int형으로 선언했다면 계산 시에는 double형으로 바꿔주는 방법도 있다
        //public long[] solution(int x, int n)
        //{
        //    long[] answer = new long[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        answer[i] = (long)x * (i + 1);
        //    }
        //    return answer;
        //}
    }
}
