public class Solution {
    public int solution(int num) {
        int answer = 0;
        long n = num;
        while(n!=1){
            if(answer>500) {
                answer = -1;
                break;
            }
            if(n%2==0){
                n/=2;
            }
            else{
                n=n*3+1;
            }
            answer++;
        }
        return answer;
    }
} //626331의 경우 중간에 int형의 크기를 넘는 경우가 나오므로 음수로 바뀐다. 따라서 500번 이내에 계산이 끝나버림. 이를 막기 위해 long으로 선언해주어야 함