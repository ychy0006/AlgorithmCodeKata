using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.
namespace AlgorithmCodeKata
{
    internal class Problem2
    {
        //내 풀이
        public double solution(int[] arr)
        {
            int answer = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                answer += arr[i];
            }

            return (double)answer / arr.Length;
        }
        //다른 사람 풀이
        //public double solution(int[] arr)
        //{
        //    return arr.Average(); //using System.Linq;
        //}
    }
}
