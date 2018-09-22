public class Solution {
    private int lo, max;
    public string LongestPalindrome(string s) {
        int slength = s.Length;
        if(slength < 2) return s;
        for(int i = 0; i < slength - 1; ++i){
            find(s, i, i);
            find(s, i, i+1);
        }
        Console.WriteLine($"lo is {lo}, max is {max}" );
        return s.Substring(lo, max);
    }
    private void find(string s, int j, int k){
        int slength = s.Length;
        while(j >= 0 && k < slength && s[j] == s[k]){
            --j;
            ++k;
        }
        if(k - j - 1 > max){
            max = k - j - 1;
            lo = j + 1;
        }
    }
}