// Leetcode
// 20. Valid Parentheses

class Solution
{
    deque<char> ph;
    public:
    bool isValid(string& s)
    {
        for (auto c : s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                ph.push_back(c);
            }
            else
            {
                if (c == ')' && ph.size() != 0 && ph[ph.size() - 1] == '(')
                {
                    ph.pop_back();
                }
                else if (c == ']' && ph.size() != 0 && ph[ph.size() - 1] == '[')
                {
                    ph.pop_back();
                }
                else if (c == '}' && ph.size() != 0 && ph[ph.size() - 1] == '{')
                {
                    ph.pop_back();
                }
                else
                {
                    return false;
                }
            }
        }
        return ph.size() == 0;
    }
};