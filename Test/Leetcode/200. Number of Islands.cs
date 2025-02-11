// Leetcode
// 200. Number of Islands

class Solution
{
    void dfs(int x, int y, int comp, vector<vector<int>>& marked, vector<vector<char>>& grid)
    {
        marked[x][y] = comp;
        if (x != 0 && marked[x - 1][y] == -1)
        {
            dfs(x - 1, y, comp, marked, grid);
        }
        if (y != 0 && marked[x][y - 1] == -1)
        {
            dfs(x, y - 1, comp, marked, grid);
        }
        if (x != marked.size() - 1 && marked[x + 1][y] == -1)
        {
            dfs(x + 1, y, comp, marked, grid);
        }
        if (y != marked[0].size() - 1 && marked[x][y + 1] == -1)
        {
            dfs(x, y + 1, comp, marked, grid);
        }
    }
    public:
    int numIslands(vector<vector<char>>& grid)
    {
        vector<vector<int>> marked_land;
        for (auto line : grid)
        {
            vector<int> line_mark;
            for (auto c : line)
            {
                if (c == '1')
                {
                    line_mark.push_back(-1);
                }
                else
                {
                    line_mark.push_back(0);
                }
            }
            marked_land.push_back(line_mark);
        }
        int ans = 0;
        for (int i = 0; i < marked_land.size(); ++i)
        {
            for (int j = 0; j < marked_land[i].size(); ++j)
            {
                if (marked_land[i][j] == -1)
                {
                    dfs(i, j, ans, marked_land, grid);
                    ++ans;
                }
            }
        }
        return ans;
    }
};