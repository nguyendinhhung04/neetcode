public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        bool[] canCheck = new bool[nums.Length];

        int min = 10000001;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] < min) min = nums[i];
            canCheck[i] = true;
        }

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] >  target - min) canCheck[i] = false;
        }

        for(int i = 0; i<nums.Length-1; i++)
        {
            if(canCheck[i]==false) continue;

            for(int j = i+1; j< nums.Length; j++)
            {
                if(nums[j] + nums[i] == target) return new int[2]{i,j};
            }
        }

        return new int[2]{-1,-1};
    }
}
