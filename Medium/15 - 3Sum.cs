public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var list = nums.OrderBy(x => x).ToList();
        var result = new List<IList<int>>();

        for(int i = 0; i < list.Count(); i++)
        {
            if(list[i] > 0)
            {
                break;
            }
            
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
         var i = 0;
         var j = list.Count() - 1;
         var result = new List<IList<int>>();
        
        while(i < j)
        {
            var sum = list[i] + list[j];
            
            if(sum == target)
            {
                var pair = new List<int> {list[i], list[j]};
                                
                if(!result.Any(x => x[0] == pair[0] && x[1] == pair[1]))
                {
                    result.Add(pair);
                    continue;
                }
            }
            
            if(sum <= target)
            {
                i++;
            }

            if(sum > target)
            {
                j--;
            }
        }
        
        return result;
    }
}