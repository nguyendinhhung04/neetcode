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

        int[] result = new int[k];
        List<int> temp = dict.Keys.ToList();
        int count = 0;

       while (count<k)
       {
            int mostFrequentElement = temp[0];
            for(int i=1 ; i<temp.Count; i++)
            {
                if( dict[temp[i]] > dict[mostFrequentElement] )
                {
                    mostFrequentElement = temp[i];
                }
            }

            result[count] = mostFrequentElement;
            temp.Remove(mostFrequentElement);
            count++;
       }

        return result;
    }
}
