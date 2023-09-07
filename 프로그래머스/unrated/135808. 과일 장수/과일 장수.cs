using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        //score길이에서 m으로 나누고 남은 나머지의 개수만큼 버릴 수 있다
        //최하품을 버리자
        //버리고 난 후의 최하품은 끼리끼리모아야 함. 어차피 들어가긴해야하니까
        //이 말은 곧 최상품도 끼리끼리 모아야 한다는 것
        //이렇게 풀면 k가 있을 의미가 없음.. 더 빠른 방법이 잇나봄..
        int answer = 0;
        Array.Sort(score);
        for(int i=score.Length-1;i>score.Length%m;i-=m){
            answer+=score[i-m+1]*m;
        }
        
        return answer;
    }
}