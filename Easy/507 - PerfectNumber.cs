public class Solution {
    public bool CheckPerfectNumber(int num) 
    {
        var sum = 0;
        for(int i = 1; i < num / 2 + 1; i++)    
        {
            if(IsDivisor(num, i))
            {
                sum += i;
            }
        }

        return sum == num;
    }

    public bool IsDivisor(int num, int divisor)
    {
        return num % divisor == 0;
    }
}