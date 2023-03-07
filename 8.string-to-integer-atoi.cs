/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
public class Solution
{
    public int MyAtoi(string s)
    {
        if (s.Length == 0)
            return 0;
        int index = 0;

        //white space
        while (s[index] == ' ')
        {
            if (++index == s.Length)
                return 0;
        }

        //negative
        bool isNegative = false;
        switch (s[index])
        {
            case '-': isNegative = true; index++; break;
            case '+': index++; break;
        }
        //int
        int result = 0;
        int upperLimit = (int.MaxValue / 10);
        int lastDigitOfMaxInt = int.MaxValue % 10;
        for (int i = index; i < s.Length && s[i] >= '0' && s[i] <= '9'; i++)
        {
            int digit = s[i] - '0';
            if (result > upperLimit || result == upperLimit && digit > lastDigitOfMaxInt)
                return isNegative ? int.MinValue : int.MaxValue;
            result = result * 10 + digit;
        }
        return isNegative ? -result : result;
    }
}
// @lc code=end

