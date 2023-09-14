using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        Array.Sort(lost);
        Array.Sort(reserve);
        int[] _lost = (int[])lost.Clone();
        int[] _reserve = (int[])reserve.Clone();
        List<int> tmp = new List<int>();
        int j=0;
        for(int i=0;i<lost.Length;i++){
            for(;j<reserve.Length;j++){
                if(reserve[j]>lost[i]) break;
                if(reserve[j]==lost[i]) {
                    tmp.Add(lost[i]);
                    break;
                }
            }
        }
        foreach(int i in tmp){
            _lost=_lost.Where(num => num != i).ToArray(); //대입안해도 오류가 안일어나서 대입 저절로 되는줄,,,
            _reserve=_reserve.Where(num => num != i).ToArray();
        }
        //순간순간만 보면 되나?
        int prev= -1;
        int count=0;
        for(int i=0;i<_lost.Length;i++){
            if(System.Array.IndexOf(_reserve,_lost[i]-1)>-1&&prev!=_lost[i]-1){
                count++;
                continue;
            }
            if(System.Array.IndexOf(_reserve,_lost[i]+1)>-1){
                count++;
                prev = _lost[i]+1;
            }
        }
        answer = n - _lost.Length + count;
        return answer;
    }
}