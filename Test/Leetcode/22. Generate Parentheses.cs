// Leetcode
// 22. Generate Parentheses

class Solution
{
    public:
    vector<string> generateParenthesis(int n)
    {
        vector<string> res;
        dfs(0, 0, "", n, res);
        return res;
    }
    private:
    void dfs(int open_p, int close_p, string s, int n, vector<string>& res)
    {
        if (open_p == close_p && open_p + close_p == n * 2)
        {
            res.push_back(s);
            return;
        }
        if (open_p < n)
        {
            dfs(open_p + 1, close_p, s + "(", n, res);
        }
        if (close_p < open_p)
        {
            dfs(open_p, close_p + 1, s + ")", n, res);
        }
    }
};