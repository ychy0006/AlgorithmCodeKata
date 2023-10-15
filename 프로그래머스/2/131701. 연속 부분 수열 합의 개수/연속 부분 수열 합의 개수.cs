using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) {
        List<int> elementsList = new List<int>();
        Dictionary<int,bool> answerList = new Dictionary<int,bool>();
        //List<int> answerList = new List<int>();
        //리스트 사용 시 .Contains()메서드 사용 시 리스트의 시작부터 검사하므로 시간 오래 걸림
        int total = 0;
        for(int j=0;j<2;j++){
            for(int i=0;i<elements.Length;i++){
                elementsList.Add(elements[i]);
                if(j==0) total+= elements[i];
            }
        }
        answerList.Add(total,true);
        for(int index=0;index<elements.Length-1;index++){
            int sum=0;
            for(int k=0;k<elements.Length-1-index;k++){
                sum+=elementsList[index+k];
                if(!answerList.ContainsKey(sum)) answerList.Add(sum,true);
                if(!answerList.ContainsKey(total-sum)) answerList.Add(total-sum,true);
            }
        }
        //i=0에서 시작해서 j=0,1,2,3일때 total에서 뺀 값들까지 하면 저절로 (i=1,j=3),(2,2),(3,1),(4,0)까지 해결됨. 
        //i=1,j=0,1,2일때 저절로 (2,3),(3,2),(4,1) 해결됨
        //i=2,j=0,1일때 저절로 (3,3),(4,2) 해결됨
        //i=3,j=0일때 저절로 (4,3) 해결됨
        return answerList.Count; 
    }
}