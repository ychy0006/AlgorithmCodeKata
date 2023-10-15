using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        int[] sortArr = citations.OrderByDescending(n => n).ToArray();
        answer = sortArr.Length;
        for(int i=0;i<sortArr.Length;i++){
            if(i+1>sortArr[i]){
                answer=i;
                break;
            }
        }
        return answer;
    }
}