// Link to the question: https://leetcode.com/problems/find-all-duplicates-in-an-array/description/

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        if (nums.Length == 1) return new int[0];

        List<int> duplicates = new List<int>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++){
            if (i == nums.Length - 1) break;

            if (nums[i] == nums[i+1]){
                duplicates.Add(nums[i]);
                i++;
            }
        }
        return duplicates;
    }
}