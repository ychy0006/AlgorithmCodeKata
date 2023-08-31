public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        //int[,] answer = new int[arr1.GetLength(1),arr1.GetLength(0)] {{}};
        //A constant value is expected
        int rowLength = arr1.GetLength(0);
        int columnLength= arr1.GetLength(1);
        
        int [,] answer = new int[rowLength,columnLength];
        for(int j=0;j<arr1.GetLength(0);j++){
            for(int i = 0;i<arr1.GetLength(1);i++) answer[j,i] = arr1[j,i] + arr2[j,i];
        }
        return answer;
    }
}