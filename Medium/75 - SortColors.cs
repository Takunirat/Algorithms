public class Solution {
    // Dutch National Flag problem
    // https://www.geeksforgeeks.org/sort-an-array-of-0s-1s-and-2s/
    public void SortColors(int[] nums) {
        int low = 0;
        int mid = 0;
        int hi = nums.Length - 1;

        while(mid <= hi)
        {
            switch(nums[mid])
            {
                case(0):
                {
                    Swap(nums, low++, mid++);
                    break;
                }
                case(1):
                {
                    mid++;
                    break;
                }
                case(2):
                {
                    Swap(nums, hi--, mid);
                    break;
                }
            }
        }
    }

    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}