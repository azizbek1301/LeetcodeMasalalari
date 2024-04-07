
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var dubs=new List<int>();
        var result = new List<int>();
        
        for(int i = 0;  i < nums.Length; i++)
        {
            int item = Math.Abs(nums[i]);
            int index = item - 1;

            if (nums[index] < 0)
            {
                dubs.Add(item);
            }
            if (nums[index] > 0)
            {
                nums[index] = -1 * nums[index];
            }
        }
        for (int i = 0;i<nums.Length;i++)
        {
            if (nums[i] < 0)
            {
                continue;
            }
            result.Add(i+1);
        }
        return result;
        
        
    }
}