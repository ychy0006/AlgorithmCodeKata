using System;

public class Solution {
    public int solution(int n) {
        string s = "";
        while(true){
            s+=(n%3).ToString();
            n/=3;
            if(n==0) break;
        }
        
        char[] c = s.ToCharArray();
        
        double answer=0;
        for(int i=0;i<s.Length;i++){
            answer+=double.Parse(c[i].ToString())*Math.Pow(3,s.Length-1-i);
        }
        
        return (int)answer;
    }
}