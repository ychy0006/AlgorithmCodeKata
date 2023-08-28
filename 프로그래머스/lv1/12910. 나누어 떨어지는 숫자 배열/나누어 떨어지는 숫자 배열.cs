public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer;
        int count = 0;
        foreach(int i in arr){
            if(i%divisor==0){
                count++;
            }
        }
        if(count==0){
            answer = new int[1] {-1};
            return answer;
        }
        answer = new int[count];
        int j=0;
        foreach(int i in arr){
            if(i%divisor==0){
                answer[j++]=i;
            }
        }
        System.Array.Sort(answer);
        return answer;
    }
}