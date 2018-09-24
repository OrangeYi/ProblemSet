public class Solution {
    private int cheeknumber(char s){
        if(s == 43 || s == 45){
          return 1;
        }
        if(s<=57 && s>=48){
            return 2;
        }
        return 3;
    }
    public int MyAtoi(string str) {
        string result = String.Empty;
        str = str.TrimStart(' ');
        if(str == String.Empty) return 0;
        if(cheeknumber(str[0]) == 3){
            return 0;
        }

        for(int i = 0; i < str.Length; ++i){
            if(cheeknumber(str[i]) == 1 && result.Length > 0){
                break;
            }
            if(cheeknumber(str[i]) != 3){
                result += str[i];
                continue;
            }
            break;
        }
        if(result[0].CompareTo('+') == 0){
            if(result.Length == 1) return 0;
            result = result.Substring(1);
        }
        int resultint = 0;
        if(result == String.Empty) return 0;
        if(result.Length == 1 && result[0].CompareTo('-') == 0) return 0;
        if(result[0].CompareTo('-') == 0){
            result = result.Substring(1);
            result = result.TrimStart('0');
            if(result == String.Empty){
                return 0;
            }
            result = "-" + result;
        }
        result = result.TrimStart('0');
        if(result == String.Empty) return 0;
        if(result.Length > 11){
            if(result[0].CompareTo('-') == 0){
                resultint = Int32.MinValue;
            }else{
                resultint = Int32.MaxValue;
            }
            return resultint;
        }
        long newlong = Convert.ToInt64(result);
        
        if(newlong > Int32.MaxValue) {
            resultint = Int32.MaxValue;
            return resultint;
        }
        if(newlong < Int32.MinValue) {
            resultint = Int32.MinValue;
            return resultint;
        } 
        resultint = Convert.ToInt32(result);
        return resultint;
    }
}