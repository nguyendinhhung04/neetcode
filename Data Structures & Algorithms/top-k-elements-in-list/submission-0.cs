public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int , int> dict = new Dictionary<int, int>();

        foreach(int i in nums)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict[i] = 0;
            }
        }

        int[] result = new int[2];
        List<int> temp = dict.Keys.ToList();
        
        if(temp.Count ==1)
        {
            return new int[1] {temp[0]};
        }

        if(dict[temp[0]] > dict[temp[1]] )
        {
            result[0] = temp[0];
            result[1] = temp[1];
        }
        else
        {
            result[0] = temp[1];
            result[1] = temp[0];
        }

        for(int i = 2; i<temp.Count; i++)
        {
            if(dict[temp[i]] > dict[result[1]])
            {
                if(dict[temp[i]] > dict[result[0]] )
                {
                    result[1] = result[0]; 
                    result[0] = temp[i];
                }
                else
                {
                    result[1] = temp[i];
                }
            }
        }

        return result;
    }
}
