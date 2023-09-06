public class Solution {
    public bool CanJump(int[] nums) {
        if(nums.Length == 1)
        {
           return true;
        }
        
        return CanJump(nums, nums.Length - 1);
    }

    public bool CanJump(int[] nums, int current)
    {
        if(current == 0)
        {
            return true;
        }
        
        for(int i = current - 1; i >= 0; i--)
        {
            if(nums[i] >= current - i)
            {
                if(CanJump(nums, i))
                {
                    return true;
                }
                else
                {
                    nums[i] = 0;
                }
            }
        }

        return false;
    }
}