public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(i == j)
                {
                    continue;
                }

                if(nums[i] + nums[j] == target)
                {
                    return new int[] {i, j};
                }
            }
        }

        return null;
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         var basic = nums.ToArray();
         nums = nums.OrderBy(x => x).ToArray();
         var lo = 0;
         var hi = nums.Length - 1;
        
        while(lo < hi)
        {
            var sum = nums[lo] + nums[hi];
            
            if(sum == target)
            {
                return new int[] {Array.IndexOf(basic, nums[lo]), Array.LastIndexOf(basic, nums[hi])};
            }
            
            if(sum < target)
            {
                lo++;
            }

            if(sum > target)
            {
                hi--;
            }
        }
        
        return null;
    }
}
