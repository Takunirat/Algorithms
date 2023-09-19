public class Solution {
    public int Jump(int[] nums) {
        if(nums.Length == 1)
        {
           return 0;
        }

        next = new List<int>();
        next.Add(0);
        global = new List<int>();
        
        return Jump(nums, 0);
    }

    public int Jump(int[] nums, int jumps)
    {
        currents = next.ToList();
        next = new List<int>();
        foreach(int i in currents.ToList())
        {
            if(i == nums.Length - 1)
            {
                return jumps;
            }

            for(int g = i; g <= i + nums[i]; g++)
            {
                if(g > nums.Length - 1)
                {
                    break;
                }
                
                if(g > i && g < nums.Length - 1 && nums[g] < nums[g - 1])
                {
                    continue;
                }
                
                if(!next.Contains(g) && !global.Contains(g) && g <= nums.Length - 1)
                {
                    next.Add(g);
                    global.Add(g);
                }
            }
        }
        
        return Jump(nums, jumps + 1);
    }

    private List<int> currents;
    private List<int> next;
    private List<int> global;
}