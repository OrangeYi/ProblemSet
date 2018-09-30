public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int numslength = nums.Length;
        Array.Sort(nums);
        int result = 0;
        int dis = Int32.MaxValue;
        for(int i = 0; i < numslength - 2; ++i){
            int lo = i + 1, hi = numslength - 1;
            while(lo < hi){
                //temp distance signed
                int temp = target- (nums[i] + nums[lo] + nums[hi]);
                if(Math.Abs(temp) < dis){
                    dis = Math.Abs(temp);
                    result = nums[i] + nums[lo] + nums[hi];
                }
                
                if(temp == 0){
                    result = target;
                    return result;
                }else if(temp < 0){
                    hi--;
                }else{
                    lo++;
                }
            }
        }       
        return result;
    }
}