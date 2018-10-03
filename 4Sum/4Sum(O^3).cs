public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>{};
        if(nums.Count() == 0 || nums == null) return result;
        Array.Sort(nums);
        int nlength = nums.Length;
        for(int i = 0; i < nlength - 3; ++i){
            if(i != 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i + 1; j < nlength - 2; ++j){
                if(j != i + 1 && nums[j] == nums[j - 1]) continue;
                int lo = j + 1, hi = nlength - 1;
                while(lo < hi){
                    int ressum = target - (nums[i] + nums[j] + nums[lo] + nums[hi]);
                    if(ressum == 0){
                        IList<int> newcom = new List<int>{nums[i], nums[j], nums[lo], nums[hi]};
                        result.Add(newcom);
                        while(lo < hi && nums[lo] == nums[lo + 1]) ++lo;
                        while(lo < hi && nums[hi] == nums[hi - 1]) --hi;
                        lo++;
                        hi--;
                    }else if(ressum < 0){
                        --hi;
                    }else ++lo;
                }
            }
        }
        return result;
    }
}
