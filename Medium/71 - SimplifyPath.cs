public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
        var part = string.Empty;
        var i = 0;
        
        while(i <= path.Length)
        {
            if( i == path.Length || path[i] == '/')
            {
                if(!string.IsNullOrEmpty(part))
                {
                    if(part == "..")
                    {
                        stack.TryPop(out var _);
                        part = string.Empty;
                        continue;
                    }

                    if(part == ".")
                    {
                        part = string.Empty;
                        continue;
                    }
                    
                    stack.Push(part);
                }

                part = string.Empty;
                i++;
                continue;
            }

            part += path[i];
            i++;
        }

        return "/" + string.Join('/', stack.ToArray().Reverse());
    }
}