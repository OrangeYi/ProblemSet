public class Solution {
    public int Search(int[] nums, int target) {
        int length = nums.Length - 1;
        if(length == -1) return -1;
        for(int index = 0; index <= length/2; index++){
            if(target == nums[index]){
                return index;
            }
            if(target == nums[length - index]){
                return length - index;
            }
        }
        return -1;
    }
}