public class Solution {
    public int RomanToInt(string s) {
        if(s == null || s.Length == 0)
        {
            return 0;
        }
        
        if(s.Length > 1)
        {
            var substring = s.Substring(0, 2);

            switch(substring)
            {
                case("IV"): return 4 + RomanToInt(s.Substring(2)); break;
                case("IX"): return 9 + RomanToInt(s.Substring(2)); break;
                case("XL"): return 40 + RomanToInt(s.Substring(2)); break;
                case("XC"): return 90 + RomanToInt(s.Substring(2)); break;
                case("CD"): return 400 + RomanToInt(s.Substring(2)); break;
                case("CM"): return 900 + RomanToInt(s.Substring(2)); break;
                default: break;
            }
        }

        switch(s[0])
        {
            case('I'): return 1 + RomanToInt(s.Substring(1)); break;
            case('V'): return 5 + RomanToInt(s.Substring(1)); break;
            case('X'): return 10 + RomanToInt(s.Substring(1)); break;
            case('L'): return 50 + RomanToInt(s.Substring(1)); break;
            case('C'): return 100 + RomanToInt(s.Substring(1)); break;
            case('D'): return 500 + RomanToInt(s.Substring(1)); break;
            case('M'): return 1000 + RomanToInt(s.Substring(1)); break;
            default: return 0;
        }
    }    
}