public class Solution {
    public bool solution(int x) {
        int sum = 0;
        for(int y = x;y>0;y/=10){
            sum += y%10;
        }
        
        bool answer = false;
        if(x%sum==0) answer = true;
        return answer;
    }
}