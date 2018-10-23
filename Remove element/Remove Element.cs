public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int alength = nums.Length;
        if(alength == 0) return 0;
        int index = 0;
        for(int i = 0; i < alength; ++i){
            if(nums[i] != val){
                nums[index++] = nums[i];
            }
        }
        return index;
    }
}