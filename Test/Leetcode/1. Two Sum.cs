// Leetcode
// 1. Two Sum

class Solution
{
    public:
    vector<int> twoSum(vector<int>& nums, int target)
    {
        vector<int> ans;
        unordered_map<int, int> hash;
        for (int i = 0; i < nums.size(); ++i)
        {
            if (hash.find(target - nums[i]) != hash.end() && hash[target - nums[i]] != i)
            {
                ans.push_back(i);
                ans.push_back(hash[target - nums[i]]);
                break;
            }
            hash[nums[i]] = i;
        }
        return ans;

    }
};