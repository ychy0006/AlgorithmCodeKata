public class Solution {
    public bool solution(string s) {
        int num;
        if((s.Length==4||s.Length==6)&&int.TryParse(s,out num)) {
            return true;
        }
        return false;
    }
}