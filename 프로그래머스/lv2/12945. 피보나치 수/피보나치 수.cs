public class Solution {
    //public int solution(int n) {
    //    int answer = (int)(Fiboancci(n) % 1234567);
    //    return answer;
    //}
    //public float Fiboancci(int n){
    //    if(n<2) return (float)n;
    //    //return (Fiboancci(n-1) + Fiboancci(n-2)) % 1234567;
    //    //그냥 이것도 안됨
    //    return Fiboancci(n-1) % 1234567 + Fiboancci(n-2) % 1234567;
    //}
    //long의 자료형까지 넘어서 오버플로우 남. 어차피 더하는 과정이므로 모든 과정에서 1234567로 나누어도 괜찮음
    //(A + B) % C = ( ( A % C ) + ( B % C) ) % C
    //그냥 재귀함수로 하면 안됨. 
    //private int[] memo;
    //public int solution(int n) {
    //    memo = new int[n + 1];
    //    return Fiboancci(n);
    //}
    //public int Fiboancci(int n) {
    //    if (n < 2) {
    //        return n;
    //    }
    //    if (memo[n] != 0) {
    //        return memo[n];
    //    }
    //    memo[n] = (Fiboancci(n - 1) % 1234567 + Fiboancci(n - 2) % 1234567) % 1234567;
    //    return memo[n];
    //}
    //하려면 이렇게 메모이제이션을 사용해 중간값을 저장하고 반환해줘야 한다. 
    //둘이 똑같은 거 아닌가.. 왜 안되는지 아직도 이해안됨
    
    public int solution(int n) {
        double answer = 0;
        double f1 = 0;
        double f2 = 1;

        for(int i = 2; i <= n; i++){
            answer = (f1 + f2) % 1234567;
            f1 = f2;
            f2 = answer;
        }
    
        return (int)answer;
    }
}