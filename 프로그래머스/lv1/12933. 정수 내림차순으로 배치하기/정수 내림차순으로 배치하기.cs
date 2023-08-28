public class Solution {
    public long solution(long n) {
            long answer = 0;

            char[] str = n.ToString().ToCharArray();
            System.Array.Sort(str); 
            System.Array.Reverse(str);
            answer = long.Parse(new string(str));

            return answer;
    }
}