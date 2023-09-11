using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 1;
        int lastPaint = section[section.Length-1];
        for(int i=section.Length-2;i>=0;i--){
            if(lastPaint-section[i]>=m){
                answer++;
                lastPaint=section[i];
            }
        }
        return answer;
    }
}