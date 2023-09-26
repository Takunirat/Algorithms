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
         var i = 0;
         var j = nums.Length - 1;
        
        while(i < j)
        {
            var sum = nums[i] + nums[j];
            
            if(sum == target)
            {
                return new int[] {Array.IndexOf(basic, nums[i]), Array.LastIndexOf(basic, nums[j])};
            }
            
            if(sum < target)
            {
                i++;
            }

            if(sum > target)
            {
                j--;
            }
        }
        
        return null;
    }
}
