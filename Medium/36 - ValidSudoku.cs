public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        return IsValidRows(board) && IsValidColumns(board) && IsValidBoxes(board);
    }

    private bool IsValidRows(char[][] board)
    {
        for(int i = 0; i < Length; i++)
        {
            if(!IsValidRow(board, i))
            {
                return false;
            }
        }
        
        return true;
    }
    
    private bool IsValidRow(char[][] board, int row)
    {
        var list = new List<char>();

        for(int j = 0; j < Length; j++)
        {
            if(board[row][j] == '.')
            {
                continue;
            }
            
            if(list.Contains(board[row][j]))
            {
                return false;
            }
            else
            {
                list.Add(board[row][j]);
            }
        }

        return true;
    }

    private bool IsValidColumns(char[][] board)
    {
        for(int j = 0; j < Length; j++)
        {
            if(!IsValidColumn(board, j))
            {
                return false;
            }
        }
        
        return true;
    }

    private bool IsValidColumn(char[][] board, int column)
    {
        var list = new List<char>();

        for(int i = 0; i < Length; i++)
        {
            if(board[i][column] == '.')
            {
                continue;
            }
            
            if(list.Contains(board[i][column]))
            {
                return false;
            }
            else
            {
                list.Add(board[i][column]);
            }
        }

        return true;
    }

    private bool IsValidBoxes(char[][] board)
    {
        for(int i = 0; i < Length; i+=3)
        {
            for(int j = 0; j < Length; j+=3)
            {
                if(!IsValidBox(board, i, j))
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    private bool IsValidBox(char[][] board, int row, int column)
    {
        var list = new List<char>();

        for(int i = row; i < row + BoxLength; i++)
        {
            for(int j = column; j < column + BoxLength; j++)
            {
                if(board[i][j] == '.')
                {
                    continue;
                }
            
                if(list.Contains(board[i][j]))
                {
                    return false;
                }
                else
                {
                    list.Add(board[i][j]);
                }
            }
        }

        return true;
    }

    private int Length = 9;
    private int BoxLength = 3;
}