using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int extra=0;
        while(n>=a){
            answer+=n/a*b;
            extra=n/a*b;
            extra += n%a;
            n=extra;
        }
        return answer;
    }
}