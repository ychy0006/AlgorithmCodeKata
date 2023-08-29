public class Solution {
    public int[] solution(int[] arr) {
        int min=System.Int32.MaxValue;
        int count =0;
        int[] answer;
        foreach(int i in arr)
        {
            if(i<min) {
                min=i;
                count=1;
            }
            //if(i==min) count++;
        }
        //if(count==arr.Length) answer= new int[1] {-1};
        //else(answer = arr.Where(num => num != min).ToArray());
        answer = System.Array.FindAll(arr, num => num != min);
        if(answer.Length==0) answer = new int[1] {-1};
        
        return answer;
    }
}