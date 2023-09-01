public class Solution {
    public long[] solution(int n, int m) {
        int temp = System.Math.Max(n,m);
        if(temp==n) {
            n=m;
            m=temp;
        }
        
        long[] answer = new long[2] {1,0};
        for(int i=2;i<=n;i++){
            if(n%i==0&&m%i==0) {
                answer[0]=(long)i;
            }
        }
        if(answer[0]==1) {
            answer[1] = (n==m) ? n : n*m;
            return answer;
        }
        else{
            int i = 1;
            while(true){
                if((answer[0]*i)%n==0&&(answer[0]*i)%m==0) {
                    answer[1]=answer[0]*i;
                    break;
                }
                i++;
            }
        }
        return answer;
    }
}