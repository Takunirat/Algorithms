public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        for(int i = 0; i < candidates.Length; i++)
        {
            CombinationSum(candidates[i..], target, 0, new List<int>());
        }

        return result;
    }

    private IList<IList<int>> result = new List<IList<int>>();
    
    private void CombinationSum(int[] candidates, int target, int sum, IList<int> list)
    {
        var current = list.ToList();
        
        while(sum + candidates[0] <= target)
        {
            current.Add(candidates[0]);
            sum += candidates[0];

            if(sum == target)
            {
                result.Add(current);
                break;
            }

            if(candidates.Length > 1)
            {
                for(int i = 1; i < candidates.Length; i++)
                {
                    CombinationSum(candidates[i..], target, sum, current);
                }
            }
        }
    }
}