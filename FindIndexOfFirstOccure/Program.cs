
var s = new Solution();

Console.WriteLine(s.StrStr("sadbutsad", "sad"));

public class Solution
{
    public int StrStr(string haystack,string needle)
    {
        for(int i=0;i<haystack.Length-needle.Length+1;i++)
        {
            for(int j=1;j<needle.Length+1;j++)
            {
                if(haystack.Substring(i,j)!=needle.Substring(0,j))
                {
                    break;
                }
                if(haystack.Substring(i,j)==needle)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}