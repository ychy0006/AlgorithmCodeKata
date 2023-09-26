using System;

public class Solution {
    int zeroCount=0;
    public int[] solution(string s) {
        int[] answer = new int[2];
        while(s!="1"){
            s=binaryString(s);
            answer[0]++;
        }
        answer[1]=zeroCount;
        return answer;
    }
    public string binaryString(string s){
        int count = 0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='1') count++;
            else zeroCount++;
        }
        long binaryValue = 0;
        long loop = 1;
        while(count>0){
            binaryValue += loop*(count%2);
            loop*=10;
            count/=2;
        }
        return binaryValue.ToString();
    }
}