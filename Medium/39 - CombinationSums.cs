public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        return CombinationSum(candidates, target, 0, new List<int>()).ToList();
    }

    private IEnumerable<IList<int>> CombinationSum(int[] candidates, int target, int sum, IList<int> list)
    {
        var max = list.Count > 0 ? list.Max(): 0;
        
        for(int i = 0; i < candidates.Length; i++)
        {
            if(candidates[i] < max)
            {
                //yield break;
            }
            
            var current = list.ToList();

            if(sum + candidates[i] == target)
            {
                current.Add(candidates[i]);

                yield return current;
            }

            if(sum + candidates[i] > target)
            {
                yield break;
            }

            current.Add(candidates[i]);

            var result = CombinationSum(candidates, target, sum + candidates[i], current);

            foreach(var item in result)
            {
                yield return item;
            }
        }
    }
}