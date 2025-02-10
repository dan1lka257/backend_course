// Leetcode
// 560. Subarray Sum Equals K

class Solution
{
    public:
    int subarraySum(vector<int>& nums, int k)
    {
        unordered_map<int, int> sums;
        sums[0] = 1;
        int sum = 0, ans = 0;
        for (int num : nums)
        {
            sum += num;
            if (sums.find(sum - k) != sums.end())
            {
                ans += sums[sum - k];
            }
            ++sums[sum];
        }
        return ans;
    }
};