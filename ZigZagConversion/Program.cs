

using System.Text;

var sol = new Solution();
Console.WriteLine( sol.Convert("PAYPALISHIRING", 3));


public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        StringBuilder result = new StringBuilder();
        int cycleLen = 2 * numRows - 2;

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j + i < s.Length; j += cycleLen)
            {
                result.Append(s[j + i]);
                if (i != 0 && i != numRows - 1 && j + cycleLen - i < s.Length)
                {
                    result.Append(s[j + cycleLen - i]);
                }
            }
        }

        return result.ToString();
    }
}
