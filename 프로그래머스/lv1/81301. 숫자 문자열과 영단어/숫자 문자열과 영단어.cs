using System;

public class Solution {
    public int solution(string s) {
        string[] stArr = {"zero","one","two","three","four","five","six","seven","eight","nine"};
        string[] nArr = {"0","1","2","3","4","5","6","7","8","9"};
        for(int i=0;i<10;i++){
            if(s.IndexOf(stArr[i])>=0){
                s=s.Replace(stArr[i],nArr[i]);
            }
        }
        return int.Parse(s);
    }
}