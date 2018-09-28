public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; ++i){
            if(i == 0 || (i > 0 && nums[i] != nums[i - 1])){
                int lo = i + 1, hi = nums.Length - 1;
                int ressum = 0 - nums[i];
                while(lo < hi){
                    if(nums[lo] + nums[hi] == ressum){
                        IList<int> newlist = new List<int>{nums[i], nums[lo], nums[hi]};
                        result.Add(newlist);
                        //Console.WriteLine($"i: {i}, lo:{lo}, hi:{hi}, numslenght:{nums.Length}");
                        //Console.WriteLine($"1: {nums[lo]}, 2:{nums[lo + 1]}, 3:{nums[lo] == nums[lo + 1]}");
                        //bug fix
                        //before while(nums[lo] == nums[lo + 1] && lo < hi) compare after check lo < hi encounter array out of range...
                        while(lo < hi && nums[lo] == nums[lo + 1])lo++;
                        while(lo < hi && nums[hi] == nums[hi - 1])hi--;
                        lo++;
                        hi--;
                    }else if(nums[lo] + nums[hi] < ressum){
                       lo++;
                    }else hi--;
                }
            }
        }
        return result;
    }
}