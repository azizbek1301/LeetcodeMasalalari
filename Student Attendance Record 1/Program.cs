


public class Solution
{
    public bool CheckRecord(string s)
    {
        bool res = s.Count(x=>x=='A') < 2 && !s.Contains("LLL");
        return res;
    }
}