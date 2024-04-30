
var sol =new  Solution();

Console.WriteLine( sol.Reverse(1534236469));

public class Solution
{
    public int Reverse(int x)
    {
        string newSon = string.Empty;
        int chekManfiy = (x < 0) ? -1 : 1;
        try
        {
            checked
            {
                
                int castedNumber = (int)x;
                if (castedNumber < 10 && castedNumber > -1)
                {
                    return castedNumber;
                }
                castedNumber = Math.Abs(castedNumber);
                while (castedNumber > 9)
                {
                    newSon += (castedNumber % 10).ToString();
                    castedNumber = castedNumber / 10;
                }
                newSon += castedNumber.ToString();
                return int.Parse(newSon) * chekManfiy;

                
            }
        }
        catch (OverflowException)
        {
            return 0;
        }
    }
}