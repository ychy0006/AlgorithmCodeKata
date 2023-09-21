using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        string[] answer = new string[players.Length];
        Dictionary<string, int> rank = new Dictionary<string, int>();
        Dictionary<int, string> name = new Dictionary<int, string>();
        for(int i = 0;i<players.Length;i++){
            rank.Add(players[i],i);
            name.Add(i,players[i]);
        }
        for(int i=0;i<callings.Length;i++){
            rank[callings[i]]--;
            string aheadPlayer = name[rank[callings[i]]];
            name[rank[callings[i]]] = callings[i];
            name[rank[callings[i]]+1] = aheadPlayer;
            rank[aheadPlayer]++;
        }
        int j=0;
        foreach(string s in name.Values){
            answer[j++]=s;
        }
        return answer;
    }
}