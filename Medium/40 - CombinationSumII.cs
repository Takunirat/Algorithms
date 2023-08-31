public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        candidates = candidates.OrderBy(x => x).ToArray();
        
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
        
        if(sum + candidates[0] <= target)
        {
            current.Add(candidates[0]);
            sum += candidates[0];

            if(sum == target && !IsContains(current))
            {
                result.Add(current);
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

    private bool IsContains(IList<int> item)
    {
        foreach(var list in result)
        {
            var findSameList = true;
            
            if(list.Count() != item.Count())
            {
                continue;
            }
            
            for(int i = 0; i < list.Count(); i++)
            {
                if(list[i] != item[i])
                {
                    findSameList = false;
                }
            }

            if(findSameList)
            {
                return true;
            }
        }

        return false;
    }
}