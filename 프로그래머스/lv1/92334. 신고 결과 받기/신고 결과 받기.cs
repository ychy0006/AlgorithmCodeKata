using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        int[] count = new int[id_list.Length];
        
        Dictionary<string, int> id = new Dictionary<string, int>();
        List<int>[] reportList = new List<int>[id_list.Length];
        for(int i=0;i<id_list.Length;i++){
            id.Add(id_list[i],i);
            reportList[i] = new List<int>();
        }
        for(int i=0;i<report.Length;i++){
            string reportName = (report[i].Split(" "))[0];
            string reportedName = (report[i].Split(" "))[1];
            if(!reportList[id[reportName]].Contains(id[reportedName])){
                reportList[id[reportName]].Add(id[reportedName]);
                count[id[reportedName]]++;
            }
        }
        for(int i=0;i<id_list.Length;i++){
            if(count[i]>=k){
                for(int j=0;j<id_list.Length;j++){
                    if(reportList[j].Contains(i)) answer[j]++;
                }
            }
        }
        return answer;
    }
}