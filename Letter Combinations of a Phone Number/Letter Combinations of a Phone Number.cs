public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>{};
        if(string.IsNullOrEmpty(digits)) return result;
        
        
        IList<string> two = new List<string> {"a", "b", "c"};
        IList<string> three = new List<string> {"d", "e", "f"};
        IList<string> four = new List<string> {"g", "h", "i"};
        IList<string> five = new List<string> {"j", "k", "l"};
        IList<string> six = new List<string> {"m", "n", "o"};
        IList<string> seven = new List<string> {"p", "q", "r", "s"};
        IList<string> eight = new List<string> {"t", "u", "v"};
        IList<string> night = new List<string> {"w", "x", "y", "z"};
        IList<IList<string>> all = new List<IList<string>>{two, three, four, five, six, seven, eight, night};
        int stringlength = digits.Length;
        int resultlength = 1;
        
        
        for(int i = 0; i < stringlength; ++i){
            resultlength = resultlength * all[digits[i] - '0' - 2].Count;
        }
        int range = (resultlength) / all[(digits[0])- '0' - 2].Count;
        Console.WriteLine(range);
        
        for(int i = 0; i < stringlength; ++i){
            int onerange = (resultlength) / all[(digits[0])- '0' - 2].Count;
            if(i == 0){
                Console.WriteLine(onerange);
                for(int j = 0; j < all[(digits[i]) - '0' - 2].Count ; ++j){
                    int index = 0;                    
                    while(index < onerange){
                        result.Add(all[(digits[i]) - '0' - 2][j]);
                        index++;
                    }
                }
            }else{
                range = range/all[(digits[i])- '0' - 2].Count;
                Console.WriteLine(range);
                int index = 0;
                for(int j = 0; j < resultlength;){
                    if(index == all[(digits[i])- '0' - 2].Count){
                        index = 0;
                    }
                    int addtimes = 0;
                    while(addtimes < range){
                        result[j] += all[(digits[i])- '0' - 2][index];
                        j++;
                        addtimes++;
                    }
                    index++;
                }
                Console.WriteLine(onerange/all[(digits[i])- '0' - 2].Count);
            }
        }
        return result;
    }
}