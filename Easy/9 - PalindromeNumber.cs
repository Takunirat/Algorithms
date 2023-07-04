public class Solution {
    public bool IsPalindrome(int x) 
    {
        var arr = x.ToString().ToCharArray();

        for(int i = 0; i < arr.Count() / 2; i++)
        {
            if(arr[i] == arr[arr.Count() - 1 - i])
            { 
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}