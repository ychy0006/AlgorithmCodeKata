using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        int xCount=1;
        
        int i = 0;
        char x = s[i];
        
        for(int j=1;j<s.Length;j++){
            i++;
            if(s[j]==x){
                xCount++;
            }
            if(xCount*2==i+1){
                if(j+1<s.Length) {
                    j++;
                    x=s[j];
                    xCount=1;
                    i=0;
                    answer++;
                    continue;
                }
                else {
                    break;
                }
            }
        }
        return answer+1;
    }
}