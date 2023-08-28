public class Solution {
    public string solution(string phone_number) {
        string s ="";
        for(int i=0;i<phone_number.Length-4;i++){
            s += "*";
        }
        //string s= new string('*',phone_number.Length-4);
        //0일 때 처리 확실하게 해줘야함
        
        string str = phone_number.Substring(phone_number.Length-4,4);
        string answer = s+str;
        return answer;
    }
}