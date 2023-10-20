using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        Dictionary<string,int> type = new Dictionary<string,int>();
        for(int i=0;i<clothes.GetLength(0);i++){
            string s = clothes[i,1];
            if(type.ContainsKey(s)) type[s]++;
            else type.Add(s,1);
        }
        List<int> typeList = new List<int>();
        foreach(int value in type.Values){
            typeList.Add(value);
        }
        //for(int i=0;i<(1<<typeList.Count);i++){
        //    int product = 1;
         //   for (int j = 0; j < typeList.Count; j++)
        //    {
        //        if ((i & (1 << j)) != 0) product*=typeList[j];
         //       else product*=1;
         //   }
        //    answer+=product;
        //}
        for(int i=0;i<typeList.Count;i++){
            answer *= (typeList[i]+1);
        }
        answer--;
        
        
        return answer;
    }
}