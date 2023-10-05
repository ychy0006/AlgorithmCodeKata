using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        int Divisor = n/2;
        while((a-1)/Divisor==(b-1)/Divisor){
            answer++;
            Divisor/=2;
        }
        answer = (int)Math.Log(n, 2) - answer;

        return answer;
    }
}