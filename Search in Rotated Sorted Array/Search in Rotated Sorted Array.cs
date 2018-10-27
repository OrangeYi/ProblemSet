public class Solution {
    public int Search(int[] nums, int target) {
        int hi = nums.Length - 1;
        if(hi == -1) return -1;//check empty array
        
        int index = hi / 2;
        int lo = 0;
        while(index >= 0){
            if(nums[index] == target){
                return index;
            }
            if(nums[lo] == target){
                return lo;
            }
            if(nums[hi] == target){
                return hi;
            }
            if((hi - lo) <= 1) break;//if only have 2 element to compare and neither not match then break
            
            if(target > nums[index]){
                if(nums[lo] > nums[index]){
                    lo = index;
                    index = (hi + lo) / 2;
                    continue;
                }else{
                    lo = index;
                    index = (hi + lo) / 2;
                    continue;
                }
            }
            if(target < nums[index]){
                if(nums[lo] > nums[index]){
                    hi = index;
                    index = (hi + lo) / 2;
                    continue;
                }else{
                    if(target > nums[hi]){
                        hi = index;
                        index = (hi + lo) / 2;
                        continue;
                    }else{
                        lo = index;
                        index = (hi + lo) / 2;
                        continue;
                    }       
                }
                
            }
        }
        return -1;
    }
}