/*
*Leet Code Solution
*1. Two Sum (Easy)
*C#
*/


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {   
            if (dict.ContainsKey(target - nums[i])) // checks if compliment is in dict
            {
                return new int[] { dict[target - nums[i]], i };
            }
            else if (!dict.ContainsKey(nums[i])) // add to dict if not already there
            {
                dict.Add(nums[i], i);
            }
        }
        
        return null;
    }
}