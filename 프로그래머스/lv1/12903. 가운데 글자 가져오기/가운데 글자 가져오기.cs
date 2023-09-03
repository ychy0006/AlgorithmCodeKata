public class Solution {
    public string solution(string s) {
        char[] arr = s.ToCharArray();
        char[] ansarr;
        if(arr.Length%2==0){
            ansarr = new char[2];
            ansarr[0]=arr[arr.Length/2-1];
            ansarr[1]=arr[arr.Length/2];
        }
        else{
            ansarr = new char[1] {arr[(arr.Length-1)/2]};
        }
        string answer = new string(ansarr);
        return answer;
    }
}