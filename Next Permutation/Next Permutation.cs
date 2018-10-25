public class Solution {
    public void NextPermutation(int[] nums) {
        int length = nums.Length;
        if(length == 1 || length == 0){
            return;
        }
        int i = length - 2;
        int k = length - 1;
        for(; i >= 0; i--){
            if(nums[i] < nums[i + 1]) {
                break;
            }
        }
        if(i < 0){
            Array.Reverse(nums, 0, length);
            return;
        }else{
            for(; k > i; k--){
                if(nums[k] > nums[i]){
                    break;
                }
            }
        }
        int temp = nums[i];
        nums[i] = nums[k];
        nums[k] = temp;
        Array.Reverse(nums, i + 1, length - i - 1);
    }
}