using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] curPos = new int[] {-1,-1};
        for(int i =0;i<park.Length;i++){
            for(int j=0;j<park[0].Length;j++){
                if(park[i][j]=='S'){
                    curPos[0]=i;
                    curPos[1]=j;
                    break;
                }
            }
            if(curPos[0]>-1) break;
        }
        for(int i=0;i<routes.Length;i++){
            int[] FunctionResult = MoveProcedure(routes[i][0], int.Parse(routes[i].Substring(2)),curPos,park);
            if(FunctionResult[0]!=-1){
                curPos[0]=FunctionResult[0];
                curPos[1]=FunctionResult[1];
            }
        }
        return curPos;
    }
    
    private int[] MoveProcedure(char direction, int distance, int[] curPos, string[] park){
        int[] answer = new int[] {curPos[0], curPos[1]};
        for(int i=0;i<distance;i++){
            if(direction=='E') answer[1]++;
            else if(direction=='W') answer[1]--;
            else if(direction=='N') answer[0]--;
            else answer[0]++;
            
            if(answer[0]<0||answer[0]>=park.Length||answer[1]<0||answer[1]>=park[0].Length){
                return new int[] {-1,-1};
            }
            else if(park[answer[0]][answer[1]]=='X') return new int[] {-1,-1};
        }
        return answer;
    }
}