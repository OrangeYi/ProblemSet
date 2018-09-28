public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0) return "";
        int arrayL = strs.Length;
        string result = "";
        int minlength = Int32.MaxValue;
        int round = 0;
        for(int i = 0; i < arrayL; ++i){
            if(strs[i].Length < minlength){
                minlength = strs[i].Length;
            }
        }
        int index = 0;
        for(int i = 0; i < minlength; ++i){
            for(int j = 0; j < arrayL; ++j){
                if(j == 0){
                    result += strs[j][i];
                    round++;
                    continue;
                }
                if(strs[j][i].CompareTo(result[i]) == 0){
                    continue;
                }else{
                    index = 1;
                    if(round < 2){
                        result = "";
                        break;
                    }
                    result = result.Substring(0, result.Length - 1);
                    break;
                }
            }
            if(index == 1) break;
        }
        return result;
    }
}