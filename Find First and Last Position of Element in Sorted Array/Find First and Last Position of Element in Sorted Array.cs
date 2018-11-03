public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int lo = 0, hi = nums.Length - 1;
        int[] res = new int[2]{-1, -1};
        if(hi == -1) return res;
        while(lo < hi){//find the left index
            int mid = (lo + hi) / 2;
            if(target > nums[mid]){
                lo = mid + 1;
            }else{
                hi = mid;
            }
        }
        if(nums[lo] != target) return res;
        res[0] = lo;
        
        hi = nums.Length - 1;
        while(lo < hi){//find the second index
            int mid = (lo + hi) / 2 + 1;
            if(target < nums[mid]){
                hi = mid - 1;
            }else{
                lo = mid;
            }
        }
        res[1] = hi;
        return res;
    }
}