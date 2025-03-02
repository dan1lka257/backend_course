// Leetcode
// 167. Two Sum II - Input Array Is Sorted

class Solution
{
    public:
    vector<int> twoSum(vector<int>& numbers, int target)
    {
        vector<int> ans;
        int l = 0;
        int r = numbers.size() - 1;
        while (l < r)
        {
            int s = numbers[l] + numbers[r];
            if (s == target)
            {
                ans = { l + 1, r + 1};
                return ans;
            }
            else if (s > target)
            {
                --r;
            }
            else
            {
                ++l;
            }
        }
        return ans;
    }
};