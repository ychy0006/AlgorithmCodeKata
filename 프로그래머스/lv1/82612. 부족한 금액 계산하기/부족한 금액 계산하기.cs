using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        int countSum=0;
        long pay;
        long presentMoney = money;
        for(int i=1;i<=count;i++) countSum += i;
        pay = (long)countSum*price;
        if(pay>presentMoney) return pay-presentMoney;
        else return 0;
        return -1;
    }
}