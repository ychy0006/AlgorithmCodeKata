using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        int index=0;
        System.Array.Sort(numbers);
        for(int n=0;n<10;n++){
            if(numbers[index]==n){
                answer-=n;
                index++;
                if(numbers.Length==index) break;
            }
        }
        return answer;
    }
}