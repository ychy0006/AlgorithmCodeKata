using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        //이차원배열 [][]이 아니라 [,]임을 주의하기
        for(int i=0;i<commands.GetLength(0);i++){
            //s=array.ToString().Substring(commands[i,0]-1, commands[i,1]-commands[i,0]+1);
            //s=s.OrderBy(x=>x).ToString();
            //answer[i]=int.Parse(s[commands[i,2]-1]);
            //역시 OrderBy의 결과인 Linq도 ToString()하면 실재하는 것을 문자열로 바꾸는 것이 아니라 주소를 문자열로 바꾸는 것이므로 오류가 난다. 
            
            //s=array.ToString().Substring(commands[i,0]-1, commands[i,1]-commands[i,0]+1);
            //배열에다가 ToString()하는 것도 주소를 문자열로 바꾸는 것. System.Int32[]이렇게 뜬다.
            int[] arr = new int[commands[i,1]-commands[i,0]+1];
            
            Array.Copy(array, commands[i,0]-1, arr, 0, commands[i,1]-commands[i,0]+1);
            Array.Sort(arr);
            answer[i]=arr[commands[i,2]-1];
        }
        return answer;
    }
}