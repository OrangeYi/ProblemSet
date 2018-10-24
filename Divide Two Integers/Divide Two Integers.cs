public class Solution {
    public int Divide(int dividend, int divisor) {
        long podend = Math.Abs((long)dividend);
        long povisor = Math.Abs((long)divisor);
        if(povisor > podend) return 0;
        bool nag = false;
        if((dividend < 0) ^ (divisor < 0)){
            nag = true;
        }
        if(povisor == 1) {
            if(nag == false && dividend == int.MinValue) return int.MaxValue;
            return nag? (int)-podend : (int)podend;   
        }
        long count = 0;
        while(podend >= povisor){
            long temp = povisor;
            long multiple = 1;
            while(podend >= (temp << 1)){
                temp <<= 1;
                multiple <<= 1;
            }
            podend -= temp;
            count += multiple;
        }
        if(nag) count = -count;
        return (int)count;
    }
}