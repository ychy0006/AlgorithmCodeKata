using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right-left+1];
        for(int i=0;i<answer.Length;i++){
            long line = (int)((i+left)/n);
            if(i+left-line*n>line) answer[i]=(int)(i+left-line*n)+1;
            else answer[i]=(int)line+1;
            
        }
        return answer;
    }
}