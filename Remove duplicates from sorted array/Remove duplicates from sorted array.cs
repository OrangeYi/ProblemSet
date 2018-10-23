public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = 1;
        int oto = nums.Length;
        if(oto == 0) return 0;
        for(int i = 1; i < oto; ++i){
            if(nums[i] != nums[i - 1]){
                nums[index++] = nums[i];
            } 
        }
        return index;
    }
}