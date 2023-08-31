public class Solution {
    public string solution(string s) {
        char[] arr=s.ToCharArray();
        System.Array.Sort(arr);
        System.Array.Reverse(arr);
        string answer = new string(arr);//arr.ToString(); 하니까 "System.Char[]"이 결과값
        return answer;
    }
}