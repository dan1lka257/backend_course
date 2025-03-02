// Leetcode
// 523. Continuous Subarray Sum

class Solution
{
    public:
    bool checkSubarraySum(vector<int>& nums, int k)
    {
        unordered_map<int, int> remains;
        remains[0] = -1;
        int curr_sum = 0;
        for (int i = 0; i < nums.size(); ++i)
        {
            curr_sum += nums[i];
            if (remains.find(curr_sum % k) != remains.end())
            {
                if (i - remains[curr_sum % k] >= 2)
                {
                    return true;
                }
            }
            else
            {
                remains[curr_sum % k] = i;
            }
        }
        return false;
    }
};