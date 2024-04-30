

Solution sol = new Solution();

var a=sol.ReverseStr("asilhre", 2);
Console.WriteLine(a);

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        if(k<0 ||  k>s.Length)
        {
            return null;
        }
        string str = string.Empty;
        for (int i = k; i >=0; i--)
        {
            str+= s[i];
        }
        for (int i = k; i <s.Length;i++)
        {
            str+= s[i];
        }

        return str;
    }
}