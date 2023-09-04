using System;
using System.Linq;

public class Solution {
    public int solution(int[,] sizes) {
        int[] maxValue = new int[sizes.GetLength(0)];
        int[] minValue = new int[sizes.GetLength(0)];
        
        for(int i=0;i<sizes.GetLength(0);i++){
            maxValue[i] = (sizes[i,0]>=sizes[i,1]) ? sizes[i,0] : sizes[i,1];
            minValue[i] = (sizes[i,0]>=sizes[i,1]) ? sizes[i,1] : sizes[i,0];
        }
        int width=maxValue.Max();
        int height=minValue.Max();
        return width*height;
    }
}