public class Solution {
    public string Convert(string s, int numRows) {
        GoDown(s, numRows, 0, 0);

        return string.Concat(_list.OrderBy(x => x.Row).Select(x => x.Character).ToArray());
    }

    public void GoDown(string s, int numRows, int row, int column)
    {
        CharacterPosition position = new CharacterPosition
        {
            Character = s[0],
            Row = row,
            Column = column
        };
        _list.Add(position);

        if(s.Count() == 1)
        {
            return;
        }

        row++;

        if(row == numRows - 1)
        {
            GoUp(s[1..], numRows, row, column);
        }
        else
        {
            GoDown(s[1..], numRows, row, column);
        }
    }

    public void GoUp(string s, int numRows, int row, int column)
    {
        CharacterPosition position = new CharacterPosition
        {
            Character = s[0],
            Row = row,
            Column = column
        };
        _list.Add(position);

        if(s.Count() == 1)
        {
            return;
        }

        row--;
        column++;

        if(row == 0)
        {
            GoDown(s[1..], numRows, row, column);
        }
        else
        {
            GoUp(s[1..], numRows, row, column);
        }
    }

    public class CharacterPosition
    {
        public char Character {get; set;}
        public int Row {get; set;}
        public int Column {get; set;}
    }

    private IList<CharacterPosition> _list = new List<CharacterPosition>();
}