

using System.Text;

public class Solution
{
    public string ReverseWords(string s)
    {
        string[]? arrayOfWords = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        StringBuilder reversStringBuilder= new StringBuilder("");

        foreach (var item in arrayOfWords)
        {
            char[] chArr= item.ToCharArray();
            Array.Reverse(chArr);
            reversStringBuilder.Append(" "+new string(chArr));
        }
        string result= reversStringBuilder.ToString().Substring(1);
        return result;
    }
}