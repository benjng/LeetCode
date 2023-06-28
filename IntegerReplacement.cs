// Link to the question: https://leetcode.com/problems/integer-replacement/description/

public class Solution {
    public int CheckN(uint n, int i){
        if (n == 1) return i;
        i++;

        if (n == 3){
            return CheckN(n-1, i);
        }

        if (n % 2 == 0){
            return CheckN(n/2, i);
        }

        if (((n + 1)/2)%2 == 0){
            return CheckN(n+1, i);
        }
        return CheckN(n-1, i);
    }

    public int IntegerReplacement(int n) {
        return CheckN((uint)n, 0);
    }
}