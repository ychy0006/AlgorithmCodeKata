public class Solution {
    public string solution(int a, int b) {
        string[] day = {"FRI","SAT","SUN","MON","TUE","WED","THU"};
        int[] dateArr = new int[12] {0,31,29,31,30,31,30,31,31,30,31,30};
        int date = b-1;
        for(int i=0;i<a;i++){
            date+=dateArr[i];
        }
        return day[date%7];
    }
}