using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        System.Array.Sort(lottos);
        System.Array.Sort(win_nums);
        int zeroCount =0;
        int correctCount = 0;
        int j=0;
        foreach(int i in lottos){
            if(i==0){
                zeroCount++;
                continue;
            }
            for(;j<6;j++){
                if(i<=win_nums[j]){
                    if(i==win_nums[j]) correctCount++;
                    break;
                }
            }
        }
        int[] reward = new int[] {6,6,5,4,3,2,1};
        return new int[] {reward[correctCount+zeroCount], reward[correctCount]};
    }
}