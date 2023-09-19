using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        // [lux, luy, rdx, rdy]
        int[] answer = new int[4] {int.MaxValue, int.MaxValue,int.MinValue,int.MinValue};
        
        for(int y=0;y<wallpaper.Length;y++){
            for(int x=0;x<wallpaper[0].Length;x++){
                if(wallpaper[y][x] == '#'){
                    if(answer[0]>y) answer[0]=y;
                    if(answer[1]>x) answer[1]=x;
                    if(answer[2]<y+1) answer[2]=y+1;
                    if(answer[3]<x+1) answer[3]=x+1;
                }
            }
        }
        return answer;
    }
}