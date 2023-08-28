public class Solution {
    public string solution(string[] seoul) {
        int index = System.Array.IndexOf(seoul,"Kim");
        string answer = "김서방은 "+index+"에 있다";
        return answer;
    }
}