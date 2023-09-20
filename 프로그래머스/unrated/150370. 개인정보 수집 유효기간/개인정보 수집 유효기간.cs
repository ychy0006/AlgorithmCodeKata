using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] answer = new int[] {};
        List<int> result = new List<int>();
        
        int todayYear = int.Parse((today.Split('.'))[0]);
        int todayDate = (int.Parse((today.Split('.'))[1]) - 1) * 28 
                        + int.Parse((today.Split('.'))[2]);
        
        string[,] termsType = new string[terms.Length,2];
        for(int i=0;i<terms.Length;i++){
            termsType[i,0] = (terms[i].Split(' '))[0];
            termsType[i,1] = (terms[i].Split(' '))[1];
        }
        
        for(int i=0;i<privacies.Length;i++){
            string[] privacy = privacies[i].Split(' ');
            
            string type = privacy[1];
            
            privacy = privacy[0].Split('.');
            int joinYear = int.Parse(privacy[0]);
            int joinDate = (int.Parse(privacy[1]) - 1) * 28 + int.Parse(privacy[2]);
            
            for(int j=0;j<terms.Length;j++){
                if(termsType[j,0]==type){
                    joinDate += int.Parse(termsType[j,1]) * 28;
                    while(joinDate>12*28){
                        joinYear+=1;
                        joinDate-=12*28;
                    }
                    
                    if(joinYear < todayYear){
                        result.Add(i+1);
                    }
                    else if(joinYear == todayYear && joinDate <= todayDate){
                        result.Add(i+1);
                    }
                    
                    break;
                }
            }
            
        }
        
        return result.ToArray();
    }
}