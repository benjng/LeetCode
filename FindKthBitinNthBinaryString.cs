// Link to the question: https://leetcode.com/problems/find-kth-bit-in-nth-binary-string/description/

public class Solution {
    public char FindKthBit(int n, int k) {
        string currentStr = "0";
        string strN = FindStrN(n, currentStr, 1);
        char[] strNCharArr = strN.ToCharArray();
        return strNCharArr[k-1];
    }

    public string FindStrN(int n, string currentStr, int currentIter){
        if (n == currentIter) return currentStr;

        string reversedStr = new string(currentStr.Reverse().ToArray());
        char[] charArr = reversedStr.ToCharArray();
        for (int i = 0; i < charArr.Length; i++) {
            if (charArr[i] == '0') {
                charArr[i] = '1';
            } else if (charArr[i] == '1') {
                charArr[i] = '0';
            }
        }
        string invertedStr = new String(charArr);
        string newStr = currentStr + "1" + invertedStr.ToString();

        currentIter++;
        return FindStrN(n, newStr, currentIter);
    }
}