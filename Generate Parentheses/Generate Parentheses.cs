public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> res = new List<string>();
        generahelp(res, "", 0, 0, n);
        return res;
    }
    public void generahelp(IList<string> res, string forn, int left, int right, int n){
        if(forn.Length == n * 2){
            res.Add(forn);
            return;
        }
        if(left < n) generahelp(res, forn + "(", left + 1, right, n);
        if(right < left) generahelp(res, forn + ")", left, right + 1, n);
    }
}