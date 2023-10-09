public class Solution {
    public long solution(int n) {
        long answer = 0;
        //점화식이 피보나치 수열과 비슷
        long f1 = 1;
        long f2 = 2;

        if(n==1) answer = f1;
        else if(n==2) answer = f2;
        for(int i = 3; i <= n; i++){
            answer = (f1 + f2) % 1234567;
            f1 = f2;
            f2 = answer;
        }
        return answer;
    }
}