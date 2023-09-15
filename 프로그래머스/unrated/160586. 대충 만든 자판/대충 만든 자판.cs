using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length]; //변수로 크기 정해주려면 {}를 빼야함. 이렇게 해도 초기화됨
        int[] alpabet = new int[(int)('Z'-'A')+1];
        foreach(string s in keymap){
            for(int i=0;i<s.Length;i++){
                if(alpabet[s[i]-'A']==0){
                    alpabet[s[i]-'A']=i+1;
                }
                else{
                    alpabet[s[i]-'A'] = alpabet[s[i]-'A'] < i+1 ? alpabet[s[i]-'A'] : i+1;
                }
            }
        }
        int j = 0;
        foreach(string s in targets){
            for(int i=0;i<s.Length;i++){
                if(alpabet[s[i]-'A']==0){
                    answer[j]=-1;
                    break;
                }
                else{
                    answer[j] += alpabet[s[i]-'A'];
                }
            }
            j++;
        }
        return answer;
    }
}