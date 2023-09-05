public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] arr=s.ToCharArray();
        foreach(char c in arr){
            if(c==' ') answer+=" ";
            else{
                int charNum = (int)c+n;
                if((int)c>64&&(int)c<91&&charNum>90){
                    charNum-=26;
                }
                if((int)c>96&&(int)c<123&&charNum>122){
                    charNum-=26;
                }
                answer+=(char)charNum; //문자열에 문자 바로 추가 가능
            }
        }
        return answer;
    }
}