public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var list = nums.OrderBy(x => x).ToList();
        var result = new List<IList<int>>();

        for(int i = 0; i < list.Count(); i++)
        {
            var subNums = list.ToList();
            subNums.RemoveAt(i);
            var pairs = TwoSum(subNums, list[i] * (-1));
            
            foreach(var pair in pairs)
            {
                var triple = new List<int> {list[i], pair[0], pair[1]};
                triple = triple.OrderBy(x => x).ToList();
                
                if(!result.Any(x => x[0] == triple[0] && x[1] == triple[1] && x[2] == triple[2]))
                {
                    result.Add(triple);
                }
            }
        }

        return result;
    }

    public IList<IList<int>> TwoSum(IList<int> list, int target) {
        var result = new List<IList<int>>();
        
        for(int i = 0; i < list.Count(); i++)
        {
            for(int j = 0; j < list.Count(); j++)
            {
                if(i == j)
                {
                    continue;
                }

                if(list[i] + list[j] == target)
                {
                    var pair = new List<int> {list[i], list[j]};
                    pair = pair.OrderBy(x => x).ToList();
                
                    if(!result.Any(x => x[0] == pair[0] && x[1] == pair[1]))
                    {
                        result.Add(pair);
                    }
                }
            }
        }

        return result;
    }
}