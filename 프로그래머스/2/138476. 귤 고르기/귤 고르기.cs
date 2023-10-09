using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        var SizeSort = new Dictionary<int, int>();
        for(int i=0;i<tangerine.Length;i++){
            if(SizeSort.ContainsKey(tangerine[i])){
                SizeSort[tangerine[i]]++;
            }
            else{
                SizeSort.Add(tangerine[i], 1);
            }
        }
        var SizeSortList = new List<int>(SizeSort.Values);
        var newSizeSort = SizeSortList.OrderByDescending(x => x).ToList();
        int k_ = k;
        foreach(int v in newSizeSort) {
            if(k_<1) break;
            answer++;
            k_-=v;
        }
        return answer;
    }
}