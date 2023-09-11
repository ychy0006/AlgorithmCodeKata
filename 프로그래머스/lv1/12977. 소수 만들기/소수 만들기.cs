using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] number)
    {
        int answer = 0;
        List<int> Sum = new List<int>();
        
        for(int i=0;i<number.Length-2;i++){
            for(int j=i+1;j<number.Length-1;j++){
                for(int k=j+1;k<number.Length;k++){
                    Sum.Add(number[i]+number[j]+number[k]);
                }
             }
        }
        
        for(int i=0;i<Sum.Count;i++){
            int n = Sum[i]-1;
            bool whether = false;
            while(n>1){
                if(Sum[i]%n==0){
                    whether=true;
                    break;
                }
                n--;
            }
            if(!whether) answer++;
        }
        
        
        return answer;
    }
}