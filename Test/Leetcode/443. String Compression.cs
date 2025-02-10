// Leetcode
// 443. String Compression

class Solution
{
    public:
    int compress(vector<char>& chars)
    {
        vector<char> ans;
        char c = chars[0];
        int ctr = 1;
        for (int i = 1; i < chars.size(); ++i)
        {
            if (c == chars[i])
            {
                ++ctr;
            }
            else
            {
                ans.push_back(c);
                vector<char> digit;
                if (ctr > 1)
                {
                    while (ctr > 0)
                    {
                        digit.push_back(ctr % 10 + '0');
                        ctr /= 10;
                    }
                    for (int i = digit.size() - 1; i >= 0; --i)
                    {
                        ans.push_back(digit[i]);
                    }
                }
                c = chars[i];
                ctr = 1;
            }
        }
        ans.push_back(c);
        vector<char> digit;
        if (ctr > 1)
        {
            while (ctr > 0)
            {
                digit.push_back(ctr % 10 + '0');
                ctr /= 10;
            }
            for (int i = digit.size() - 1; i >= 0; --i)
            {
                ans.push_back(digit[i]);
            }
        }
        swap(ans, chars);
        return chars.size();
    }
};