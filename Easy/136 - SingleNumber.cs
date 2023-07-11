public class Solution {
    public int SingleNumber(int[] nums) {
        foreach(var num1 in nums)
        {
            int count = 0;
            foreach(var num2 in nums)
            {
                if(num1 == num2)
                {
                    count++;
                }
            }

            if(count == 1)
            {
                return num1;
            }
        }

        return 0;
    }
}