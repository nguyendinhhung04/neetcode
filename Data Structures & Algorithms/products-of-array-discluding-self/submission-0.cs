public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int[] result = new int[nums.Length];
       for(int i =0 ; i<result.Length ; i++)
       {
        result[i] = 1;
       }

       for(int i=0 ; i<result.Length; i++)
       {
        for(int j =0 ; j<result.Length; j++)
        {
            if(i!=j)
            {
                result[i] = result[i] * nums[j];
            }
        }
       }

        return result;
    }
}
