public class Solution
{
    public int FindNextGreaterElement(int ele, int[] arr)
    {
        int idx = Array.IndexOf(arr, ele);
        int ans = -1;
        for (int i = idx + 1; i < arr.Length; i++)
        {
            if (arr[i] > ele)
            {
                ans = arr[i];
                break;
            }
        }
        return ans;
    }
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int[]? ans = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            ans[i] = FindNextGreaterElement(nums1[i], nums2);
        }
        return ans;
    }
}