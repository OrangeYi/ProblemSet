public class Solution {
    public int StrStr(string haystack, string needle) {
        int needcount = needle.Length;
        int haystackcount = haystack.Length;
        if(needcount == 0) return 0;
        if(needcount > haystackcount) return -1;
        return haystack.IndexOf(needle);
    }
}