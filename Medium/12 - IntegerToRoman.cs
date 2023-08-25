public class Solution 
{
    public string IntToRoman(int num) 
    {
        var result = "";
        
        foreach(var item in Map.OrderByDescending(x => x.Key))
        {
            while(num >= item.Key)
            {
                result += item.Value;
                num -= item.Key;
            }
        }

        return result;
    }

    public Dictionary<int, string> Map = new Dictionary<int, string> {{1, "I"},   {4, "IV"}, {5, "V"},   {9, "IX"},  {10, "X"},
                                              {40, "XL"}, {50, "L"}, {90, "XC"}, {100, "C"}, {400, "CD"},
                                              {500, "D"}, {900, "CM"}, {1000, "M"}};
}