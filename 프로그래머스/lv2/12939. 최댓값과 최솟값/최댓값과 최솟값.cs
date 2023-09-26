public class Solution {
    public string solution(string s) {
        string[] numbers = s.Split(" ");
        int min = int.MaxValue;
        int max = int.MinValue;
        foreach(string number in numbers){
            int n = int.Parse(number);
            if(n<min) min=n;
            if(n>max) max=n;
        }
        return min.ToString() + " " + max.ToString();
    }
}