using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = strings.OrderBy(x=>x[n]).ThenBy(x=>x).ToArray();
        //이렇게만 하면 인덱스 n의 문자가 같은 문자열이 여럿인 경우에, 사전순 정렬이 되지 않는다.
        
        return answer;
    }
}