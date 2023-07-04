public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var minLength = strs.Min(x => x.Length);
        var result = string.Empty;
        
        for(var i = 1; i <= minLength; i++)
        {
            result = strs[0].Substring(0, i);

            for(var j = 1; j < strs.Length; j++)
            {
                if(strs[j].Substring(0, i) != result)
                {
                    return result.Substring(0, i - 1);
                }
            }
        }

        return result;
    }
}