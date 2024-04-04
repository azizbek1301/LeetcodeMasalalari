using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return "";
        }
        int[] longestPalindromeIndeces = { 0, 0 };

        for(int i=0;i<s.Length; i++)
        {
            int[] currentIndex = ExpandArroundCenter(s, i, i);
            if (currentIndex[1] - currentIndex[0] > longestPalindromeIndeces[1] - longestPalindromeIndeces[0])
            {
                longestPalindromeIndeces=currentIndex;
            }

            if(i+1<s.Length && s[i] == s[i+1])
            {
                int[] eventIndeces = ExpandArroundCenter(s, i, i + 1);
                if (eventIndeces[1] - eventIndeces[0] > longestPalindromeIndeces[1] - longestPalindromeIndeces[0])
                {
                    longestPalindromeIndeces = eventIndeces;
                }
            }
        }

        return s.Substring(longestPalindromeIndeces[0], longestPalindromeIndeces[1] - longestPalindromeIndeces[0] + 1);
       
    }
    public int[] ExpandArroundCenter(string s, int i,int j)
    {
        while(i>=0 && j<s.Length && s[i] == s[j])
        {
            i--;
            j++;
        }
        return new int[] { i+1, j-1 };
    }
}