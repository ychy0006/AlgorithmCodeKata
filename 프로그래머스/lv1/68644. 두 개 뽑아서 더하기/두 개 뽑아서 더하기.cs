using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer;
        List<int> list = new List<int> {};
        for(int i=0;i<numbers.Length-1;i++){
            for(int j=i+1;j<numbers.Length;j++){
                if(!list.Contains(numbers[i]+numbers[j])) list.Add(numbers[i]+numbers[j]);
            }
        }
        answer = list.OrderBy(num=>num).ToArray();
        
        return answer;
    }
}