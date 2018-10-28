public class Solution {
    public int Search(int[] nums, int target) {
        int length = nums.Length;
        if(length == 0) return -1;
        
        int hi = length - 1, lo = 0;
        while(lo < hi){
            int mid = (lo + hi) / 2;
            if(nums[mid] > nums[hi]){
                lo = mid + 1;
            }else{
                hi = mid;
            }
        }
        int smallest = lo;
        if(nums[smallest] == target) return smallest;
        if(nums[0] == target) return 0;
        if(nums[length - 1] == target) return length - 1;
        lo = target > nums[0] ? 0 : smallest + 1;
        hi = target > nums[length - 1] ? smallest - 1 : length - 1;
        while(lo <= hi){
            int mid = (lo + hi) / 2;
            if(target == nums[mid]) return mid;
            if(target > nums[mid]){
                lo = mid + 1;
            }else{
                hi = mid - 1;
            }
        }
        return -1;
    }
}public class Solution {
    public int Search(int[] nums, int target) {
        int length = nums.Length;
        if(length == 0) return -1;
        
        int hi = length - 1, lo = 0;
        while(lo < hi){
            int mid = (lo + hi) / 2;
            if(nums[mid] > nums[hi]){
                lo = mid + 1;
            }else{
                hi = mid;
            }
        }
        int smallest = lo;
        if(nums[smallest] == target) return smallest;
        if(nums[0] == target) return 0;
        if(nums[length - 1] == target) return length - 1;
        lo = target > nums[0] ? 0 : smallest + 1;
        hi = target > nums[length - 1] ? smallest - 1 : length - 1;
        while(lo <= hi){
            int mid = (lo + hi) / 2;
            if(target == nums[mid]) return mid;
            if(target > nums[mid]){
                lo = mid + 1;
            }else{
                hi = mid - 1;
            }
        }
        return -1;
    }
}