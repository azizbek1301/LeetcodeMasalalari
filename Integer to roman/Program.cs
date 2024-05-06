

public class Solution
{
    public string IntToRoman(int num)
    {
        var romanNumbers = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        string result=string.Empty;

        foreach (var item in romanNumbers.OrderByDescending(x=>x.Key))
        {
            while(num>=item.Key)
            {
                result += item.Value;
                num-=item.Key;
            }
        }
        return result;
    }
}