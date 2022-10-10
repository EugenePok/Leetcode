using System.Collections;

bool IsPalindrome(string s) {
    int l = 0;
    int r = s.Length - 1;
    char left = Char.ToLower(s[l]);
    char right = Char.ToLower(s[r]);
    while(l < r){
        if(left >= 97 && left <= 122 && right >= 97 && right <= 122){
            if (left != right) return false;
            else {
                left = Char.ToLower(s[++l]);
                right = Char.ToLower(s[--r]);
                continue;
            }
        }
        if(left < 97 || left > 122)
            left = Char.ToLower(s[++l]);
        if((right < 97 || right > 122))
            right = Char.ToLower(s[--r]);
    }
    return true;
}

Console.WriteLine(IsPalindrome("0P"));