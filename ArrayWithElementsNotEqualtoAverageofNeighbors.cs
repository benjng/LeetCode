// Link to the question: https://leetcode.com/problems/array-with-elements-not-equal-to-average-of-neighbors/description/

public class Solution {
    public int[] RearrangeArray(int[] nums) {
        Array.Sort(nums);
        bool isLengthEven = (nums.Length % 2 == 0);

        int[] newNums = new int[nums.Length];

        int j = 0;
        int half = newNums.Length / 2;
        for (int i = 0; i < newNums.Length; i += 2){ 
            newNums[i] = nums[half++];
            if (!isLengthEven && i == newNums.Length - 1) break;
            newNums[i+1] = nums[j++];
        }

        return newNums;
    }
}