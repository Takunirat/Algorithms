public class Solution {
    public bool JudgeSquareSum(int c)
    {
        var lo = 0;
        var hi = (long)Math.Ceiling(Math.Sqrt(c));

        while (lo <= hi)
        {
            var result = lo * lo + hi * hi;

            if (result == c)
            {
                return true;
            }

            if (result < c)
            {
                lo++;
            }
            else
            {
                hi--;
            }
        }

        return false;
    }
}