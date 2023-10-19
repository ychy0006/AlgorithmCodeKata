using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        
        Dictionary<string, int> wantDictionary = new Dictionary<string, int>();
        for(int i=0;i<want.Length;i++){
            wantDictionary.Add(want[i],number[i]);
        }
        
        Dictionary<string, int> discountTenDictionary = new Dictionary<string, int>();
        for(int i=0;i<discount.Length;i++){
            if(discountTenDictionary.ContainsKey(discount[i])) 
                discountTenDictionary[discount[i]]++;
            else discountTenDictionary.Add(discount[i],1);
            
            if(i>9){
                string first = discount[i-10];
                discountTenDictionary[first]--;
                if(discountTenDictionary[first]==0) 
                    discountTenDictionary.Remove(first);
            }
            
            if(i>=9){
                bool join = true;
                foreach(var wantpair in wantDictionary){
                    if(discountTenDictionary.ContainsKey(wantpair.Key)){
                        if(!(discountTenDictionary[wantpair.Key] >= wantpair.Value)){
                            join = false;
                        }
                    }
                    else join = false;
                }
                if(join==true) answer++;
            }
        }
        
        return answer;
    }
}