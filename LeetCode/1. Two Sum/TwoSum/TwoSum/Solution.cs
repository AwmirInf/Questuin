using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> mpa = new Dictionary<int, int>();
        int end = nums.Length;
        for (int i = 0; i < end; i++)
        {
            int supplement = target - nums[i];
            if (mpa.ContainsKey(supplement))
            {
                return new int[2] { mpa[supplement], i };
            }
            mpa[nums[i]] = i;
        }
        return null;
    }
}