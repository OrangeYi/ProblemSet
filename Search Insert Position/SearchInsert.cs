public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int lo = 0;
        int hi = nums.Length - 1;
        while(lo <= hi){
            int mid = (lo + hi)/2;
            if(target == nums[mid]) return mid;
            if(target < nums[mid]){
                hi = mid - 1;
            }else{
                lo = mid + 1;
            }
        }
        return lo;
    }
}