public class Solution {
    public int solution(int[] arr) {
        int answer = 1;
        for(int i=0;i<arr.Length;i++){
            int _gcd = gcd(answer, arr[i]);
            answer = answer * arr[i] / _gcd;
        }
        return answer;
    }
    private int gcd(int a, int b)
    {
        return (a % b == 0 ? b : gcd(b, a % b));
    }
}