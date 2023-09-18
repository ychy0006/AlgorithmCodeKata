using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        int length = 0;
        List<int> ingredientList = new List<int>();
        foreach(int i in ingredient){
            ingredientList.Add(i);
            length = ingredientList.Count;
            if(length>3){
                if(ingredientList[length-1]==1){
                    if(ingredientList[length-2]==3){
                        if(ingredientList[length-3]==2){
                            if(ingredientList[length-4]==1){
                                answer++;
                                ingredientList.RemoveAt(length-1);
                                ingredientList.RemoveAt(length-2);
                                ingredientList.RemoveAt(length-3);
                                ingredientList.RemoveAt(length-4);
                            }
                        }
                    }
                }
            }
        }
        return answer;
    }
}