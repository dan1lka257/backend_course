﻿// Leetcode
// 5. Longest Palindromic Substring

class Solution
{
    int expandAroundCenter(const string& s, int left, int right) {
        while (left >= 0 && right<s.length() && s[left] == s[right]) {
            left--;
            right++;
        }
return right - left - 1;
    } 
public:
    string longestPalindrome(string s)
{
    if (s.empty())
    {
        return "";
    }

    int start = 0;
    int end = 0;

    for (int i = 0; i < s.length(); i++)
    {
        int odd = expandAroundCenter(s, i, i);
        int even = expandAroundCenter(s, i, i + 1);
        int max_len = max(odd, even);

        if (max_len > end - start)
        {
            start = i - (max_len - 1) / 2;
            end = i + max_len / 2;
        }
    }

    return s.substr(start, end - start + 1);
}   
};