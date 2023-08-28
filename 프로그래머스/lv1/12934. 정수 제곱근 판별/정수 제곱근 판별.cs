public class Solution {
    public long solution(long n) {
        long i = 1;
        while(true){
            if(n==i*i){
                return (i+1)*(i+1);
            }
            i++;
            if(i>n) break;
        }
        return -1;
    }
}