using System;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int totalSum = n * (n + 1) / 2;
        int arraySum = 0;

        foreach (int num in nums)
        {
            arraySum += num;
        }

        return totalSum - arraySum;
    }
                                                                                    
    public static void Main(string[] args)
    {
        Solution solution = new Solution();                                                                                                                                                                                                                                    
        int[] nums = {3, 0, 1};
        Console.WriteLine("Missing number is: " + solution.MissingNumber(nums)); // Output: 2
    }
}