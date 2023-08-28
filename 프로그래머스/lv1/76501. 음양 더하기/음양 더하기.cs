using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        for(int i=0;i<absolutes.Length;i++){
            if(signs[i]==true) answer += absolutes[i];
            else answer += (-1*absolutes[i]);
        }
        //foreach(int i in absolutes){
            //if(signs[System.Array.IndexOf(absolutes,i)]==true) answer += i;
            //이렇게 하면 같은 절댓값 있을 시 반례 생김
            //if(signs[System.Array.IndexOf(absolutes,i)]==true) answer += i;
            //else answer += (-1*i);
        //}
        return answer;
    }
}