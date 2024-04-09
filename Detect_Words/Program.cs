public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int counter = 0;
        foreach (char c in word)
        {
            if (c >= 65 && c <= 90) counter++;
        }
        if (counter == 0 || counter == word.Length || (counter == 1 && (word[0] >= 65 && word[0] <= 90))) return true;
        return false;
    }
}