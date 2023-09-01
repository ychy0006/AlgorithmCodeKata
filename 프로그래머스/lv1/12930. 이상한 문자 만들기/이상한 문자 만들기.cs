public class Solution {
    public string solution(string s) {
        string answer = "";
        
        int i=0;
        for(int j = 0; j<s.Length;j++){
            if(s[j]!=' '){
                if(i%2==0) answer += s[j].ToString().ToUpper();
                else answer += s[j].ToString().ToLower();
            }
            i++;
            if(s[j]==' ') {
                answer += s[j];
                i=0;
            }
        }
        
        return answer;
    }
}