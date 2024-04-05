

using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if(numRows==1)
        {
            return s;
        }
        StringBuilder[] asArr= new StringBuilder[numRows];
        int r= 0;
        bool goingD = true;
        foreach (var item in s)
        {
            asArr[r].Append(item);
            if(r==0)
            {
                goingD = true;

            }
            else if (r+1== numRows)
            {
                goingD= false;
            }
            r=goingD ? r+1 : r-1;

        }

        string ziGZag = "";
        foreach (var item in asArr)
        {
            ziGZag += item.ToString();
        }
        return ziGZag;
    }
}