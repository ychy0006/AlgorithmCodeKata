﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수, solution을 완성해주세요.
namespace AlgorithmCodeKata
{
    internal class Problem4
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0) answer += i;
            }
            return answer + n;
        }
    }
}
