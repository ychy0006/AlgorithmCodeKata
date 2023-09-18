using System;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        //("d","ef",1) ("y","zab",1) 이런 경우까지 고려하기
        string answer = "";
        char[] skipArr = skip.ToCharArray();
        for(int i=0;i<s.Length;i++){
            char temp = s[i];
            for(int j=0;j<index;j++){
                temp = (char)((int)temp + 1);
                if(temp > 'z') temp = (char)((int)temp - 26);
                if(Array.IndexOf(skipArr,temp)>-1) j--;
            }
            answer += temp;
        }
        return answer;
    }
}