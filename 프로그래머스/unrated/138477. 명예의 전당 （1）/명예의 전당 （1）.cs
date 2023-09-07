using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) { //k가 score길이보다 길 수도 있다
        int[] answer = new int[score.Length]; //뒤에 {}붙이면 오류남. 크기 설정안하면 인덱스 사용못함.
        int[] arr = new int[k];
        int min = score[0];
        for(int i=0;i<Math.Min(k,score.Length);i++){
            arr[i] = score[i];
            if(min>score[i]) min=score[i];
            answer[i] = min;
        }
        Array.Sort(arr);
        if(score.Length>k){ 
            for(int i=k;i<score.Length;i++){
                for(int j=k-1;j>-1;j--){
                    if(score[i]>=arr[j]){
                        for(int h=0;h<j;h++){
                            arr[h]=arr[h+1];
                        }
                        arr[j]=score[i];
                        break;
                    }
                }
                answer[i]=arr[0];
            }
        }
        return answer;
    }
}