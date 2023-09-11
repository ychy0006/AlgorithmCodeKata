using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 1;
        for(int i=2;i<=number;i++){
            int atk = 2;
            int multipleValue=i;
            for(int j=2;j<multipleValue;j++){
                if(i%j==0) {
                    multipleValue=i/j;
                    if(multipleValue!=j) atk+=2;
                    else atk++;
                }
            }
            if(atk>limit) atk=power;
            answer+=atk;
        }
        return answer;
    }
}