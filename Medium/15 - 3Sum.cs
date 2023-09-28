public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0  || (i != 0 && nums[i - 1] == nums[i]))
            {
                continue;
            }
            
            var pairs = TwoSum(nums, nums[i] * (-1), i);
            
            foreach(var pair in pairs)
            {
                var triple = new List<int> {nums[i], pair[0], pair[1]};
                triple = triple.OrderBy(x => x).ToList();
                
                if(!result.Any(x => x[0] == triple[0] && x[1] == triple[1] && x[2] == triple[2]))
                {
                    result.Add(triple);
                }
            }
        }

        return result;
    }

    public IList<IList<int>> TwoSum(int[] nums, int target, int targetIndex) {
         var lo = 0;
         var hi = nums.Length - 1;
         var result = new List<IList<int>>();
        
        while(lo < hi)
        {
            if(lo == targetIndex)
            {
                lo++;
                continue;
            }
            
            if(hi == targetIndex)
            {
                hi--;
                continue;
            }
                        
            var sum = nums[lo] + nums[hi];
            
            if(sum == target)
            {
                var pair = new List<int> {nums[lo], nums[hi]};
                                
                if(!result.Any(x => x[0] == pair[0] && x[1] == pair[1]))
                {
                    result.Add(pair);
                }
            }
            
            if(sum <= target)
            {
                lo++;
            }

            if(sum > target)
            {
                hi--;
            }
        }
        
        return result;
    }
}