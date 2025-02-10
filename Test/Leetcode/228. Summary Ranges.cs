// Leetcode
// 228. Summary Ranges

class Solution
{
    public:
    vector<string> summaryRanges(vector<int>& nums)
    {
        vector<string> ans;
        int l = 0;
        for (int i = 1; i < nums.size(); ++i)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                if (l == i - 1)
                {
                    ans.push_back(to_string(nums[l]));
                }
                else
                {
                    ans.push_back(to_string(nums[l]) + "->" + to_string(nums[i - 1]));
                }
                l = i;
            }
        }
        if (nums.size() != 0)
        {
            if (l == nums.size() - 1)
            {
                ans.push_back(to_string(nums[l]));
            }
            else
            {
                ans.push_back(to_string(nums[l]) + "->" + to_string(nums[nums.size() - 1]));
            }
        }
        return ans;
    }
};