public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>{};
        if(nums.Count() == 0 || nums == null) return result;
        Array.Sort(nums);
        int nlength = nums.Length;
        for(int i = 0; i < nums.Length - 3; ++i){
            if(i != 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i + 1; j < nums.Length - 2; ++j){
                if(j != i + 1 && nums[j] == nums[j - 1]) continue;
                for(int k = j + 1; k < nums.Length - 1; ++k){
                    if(k != j + 1 && nums[k] == nums[k - 1]) continue;
                    for(int z = k + 1; z < nums.Length; ++z){
                        int ressum = target - (nums[i] + nums[j] + nums[k]);
                        if(z != k + 1 && nums[z] == nums[z - 1]) continue;
                        if(ressum - nums[z] == 0){
                            IList<int> newcom = new List<int>{nums[i], nums[j], nums[k], nums[z]};
                            result.Add(newcom);
                        }
                    }
                }
            }
        }
        return result;
    }
}