// Leetcode
// 1493. Longest Subarray of 1's After Deleting One Element

class Solution
{
    public:
    int longestSubarray(vector<int>& nums)
    {
        int l = 0, zero_counter = 0, ans = 0;
        for (int r = 0; r < nums.size(); ++r)
        {
            zero_counter += (nums[r] == 0);
            while (zero_counter >= 2)
            {
                if (nums[l] == 0)
                {
                    --zero_counter;
                }
                ++l;
            }
            ans = max(ans, r - l);
        }
        return ans;
    }
};