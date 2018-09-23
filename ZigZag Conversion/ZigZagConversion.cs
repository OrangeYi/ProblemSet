public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows == 1) return s;
        int slength = s.Length;
        string [] newarray = new string[numRows];
        int index = 0;
        int incr = 0;
        for(int i = 0; i < slength; ++i){
            if(index == 0) incr = 1;
            if(index == numRows - 1) incr = - 1;
            newarray[index] = newarray[index] + s[i];
            index += incr;
             
        }
        string result = "";
        for(int i = 0; i < numRows; ++i){
            result = result + newarray[i];
        }
        return result;
    }
}