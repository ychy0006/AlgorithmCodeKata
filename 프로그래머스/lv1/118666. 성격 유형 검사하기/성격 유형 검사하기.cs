using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        int[] arr = new int[4]; //순서대로 R,C,J,A의 값을 담을 배열
        char[] charArr = {'R','C','J','A','T','F','M','N'};
        
        for(int i=0;i<survey.Length;i++){
            int addValue = 0;
            int idx = 0;
            if(survey[i].Contains("R")){
                idx = 0;
            }
            if(survey[i].Contains("C")){
                idx = 1;
            }
            if(survey[i].Contains("J")){
                idx = 2;
            }
            if(survey[i].Contains("A")){
                idx = 3;
            }
            if(survey[i][1]==charArr[idx]) addValue = choices[i]-4;
            else addValue = 4-choices[i];
            
            arr[idx] += addValue;
        }
        
        for(int i=0;i<4;i++){
            if(arr[i]>=0) answer += charArr[i];
            else answer += charArr[i+4];
        }
        
        return answer;
    }
}