using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string temp = "";
        string prev = "";
        foreach(string s in babbling){
            temp = String.Copy(s);
            prev = "";
            while(true){
                if(temp == "") {
                    answer++;
                    break;
                }
                if(temp.Length>=3){
                    if(temp.IndexOf("aya", 0, 3)==0){
                        if(prev == "aya") break;
                        temp = temp.Substring(3,temp.Length-3);
                        prev = "aya";
                        continue;
                    }
                    else if(temp.IndexOf("woo", 0, 3)==0){
                        if(prev == "woo") break;
                        temp = temp.Substring(3,temp.Length-3);
                        prev = "woo";
                        continue;
                    }
                    else if(temp.IndexOf("ye", 0, 2)==0){
                        if(prev == "ye") break;
                        temp = temp.Substring(2,temp.Length-2);
                        prev = "ye";
                        continue;
                    }
                    else if(temp.IndexOf("ma", 0, 2)==0){
                        if(prev == "ma") break;
                        temp = temp.Substring(2,temp.Length-2);
                        prev = "ma";
                        continue;
                    }
                    else break;
                }
                else if(temp.Length==2)
                {
                    if(temp.IndexOf("ye", 0, 2)==0){
                        if(prev == "ye") break;
                        temp = temp.Substring(2,temp.Length-2);
                        continue;
                    }
                    else if(temp.IndexOf("ma", 0, 2)==0){
                        if(prev == "ma") break;
                        temp = temp.Substring(2,temp.Length-2);
                        continue;
                    }
                    else break;
                }
                else break;
                
            }
        }
        return answer;
    }
}