using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int card1idx=0;
        int card2idx=0;
        foreach(string s in goal){
            if(s==cards1[card1idx]) {
                card1idx++;
                if(card1idx==cards1.Length) card1idx--;
            }
            else if(s==cards2[card2idx]) {
                card2idx++;
                if(card2idx==cards2.Length) card2idx--;
            }
            else {
                answer = "No";
                break;
            }
        }
        return answer;
    }
}