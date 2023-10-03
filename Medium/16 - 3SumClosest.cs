public class Solution {
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = nums[0] + nums[1] + nums[2];

        for (int i = 0; i < nums.Length; i++)
        {
            var lo = 0;
            var hi = nums.Length - 1;

            while (lo < hi)
            {
                if (i == lo) { lo++; continue; }
                if (i == hi) { hi--; continue; }

                var sum = nums[i] + nums[lo] + nums[hi];

                if (Math.Abs(target - sum) < Math.Abs(target - result))
                {
                    result = sum;
                }

                if (sum <= target)
                {
                    lo++;
                }

                if (sum > target)
                {
                    hi--;
                }
            }
        }

        return result;
    }
}