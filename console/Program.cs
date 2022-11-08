using System.Collections;

string ExtendString(string s, int i, int j){
    for(;i >= 0 && j < s.Length; i--, j++){
        if(s[i] != s[j]) break;
    }
    return s.Substring(i + 1, j - i - 1);
}

string LongestPalindrome(string s) {
    string max = "";
    for(int i=0;i< s.Length; i++){
        string s1 = ExtendString(s,i,i), s2 = ExtendString(s, i, i+1);
        if(s1.Length > max.Length) max = s1;
        if(s2.Length > max.Length) max = s2;
    }
    return max;
}

Console.WriteLine(LongestPalindrome("cbbd"));