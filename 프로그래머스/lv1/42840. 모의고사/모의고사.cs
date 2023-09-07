using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        int[] people = new int[3] {0,0,0};
        int[] arr2 = {1,3,4,5};
        int[] arr3 = {3,1,2,4,5};
        for(int i=0;i<answers.Length;i++){
            if(answers[i]==i%5+1) people[0]++;
            if(i%2==0){
                if(answers[i]==2) people[1]++;
            }
            else{
                if(answers[i]==arr2[i%8/2]) people[1]++;
            }
            if(answers[i]==arr3[i%10/2]) people[2]++;
        }
        int max=int.MinValue;
        List<int> list = new List<int>();
        for(int i=0;i<people.Length;i++){
            if(people[i]==max){
                list.Add(i+1);
            }
            if(people[i]>max){
                max=people[i];
                list.Clear();
                list.Add(i+1);
            }
        }
        answer=list.OrderBy(x=>x).ToArray();
        return answer;
    }
}