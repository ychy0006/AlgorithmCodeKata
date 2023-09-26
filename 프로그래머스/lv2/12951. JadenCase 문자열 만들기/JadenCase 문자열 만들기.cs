public class Solution {
    public string solution(string s) {
        string answer = "";
        bool firstChar = true;
        for(int i=0;i<s.Length;i++){
            if(s[i]==' '){
                answer += " ";
                firstChar = true;
                continue;
            }
            if(firstChar){
                if(s[i]>='a'&&s[i]<='z') answer += s[i].ToString().ToUpper();
                else answer += s[i];
                firstChar = false;
            }
            else{
                if(s[i]>='A'&&s[i]<='Z') answer += s[i].ToString().ToLower();
                else answer += s[i];
            }
        }
        return answer;
    }
}