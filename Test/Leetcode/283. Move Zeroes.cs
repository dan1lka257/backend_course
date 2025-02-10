// Leetcode
// 283. Move Zeroes

class Solution
{
    public:
    void moveZeroes(vector<int>& nums)
    {
        int l = 0;
        for (int i = 0; i < nums.size(); ++i)
        {
            if (nums[i] != 0)
            {
                if (i != l) swap(nums[i], nums[l]);
                ++l;
            }
        }
    }
};