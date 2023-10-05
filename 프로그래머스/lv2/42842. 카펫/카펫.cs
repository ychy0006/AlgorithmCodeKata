using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        for(int y = 1;y<brown+yellow;y++){
            if((brown+yellow)%y==0){
                int x = (brown+yellow)/y;
                if((x-2)*(y-2)==yellow){
                    answer[0]=x;
                    answer[1]=y;
                    break;
                }
            }
        }
        return answer;
    }
}