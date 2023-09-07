using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Hashtable num = new Hashtable();
        char[] arr = s.ToCharArray();
        
        for(int i=0;i<s.Length;i++){
            if(num.Contains(arr[i])){
                answer[i]=i-(int)num[arr[i]];
                num.Remove(arr[i]);
            }
            else{
                answer[i]=-1;
            }
            num.Add(arr[i],i);
        }
        return answer;
    }
}