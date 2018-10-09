public class Solution {
    public bool IsValid(string s) {
        if(s == null) return true;
        int slen = s.Length;
        List<int> collection = new List<int>{};
        for(int i = 0; i < slen; i++){
            if(s[i] == 40 || s[i] == 91 || s[i] == 123){
                collection.Add((int)s[i]);
                continue;
            }
            if(s[i] == 41 || s[i]== 93 || s[i]== 125){
                int clen = collection.Count;
                if(s[i] == 41){
                    if(clen < 1 || collection[clen - 1] != 40) return false;
                    collection.RemoveAt(clen - 1);
                }else if(s[i]== 93){
                    if(clen < 1 || collection[clen - 1] != 91) return false;
                    collection.RemoveAt(clen - 1);
                }else if(s[i]== 125){
                    if(clen < 1 || collection[clen - 1] != 123) return false;
                    collection.RemoveAt(clen - 1);
                }
            }
        }
        if(collection.Count == 0) return true;
        return false;
    }
}