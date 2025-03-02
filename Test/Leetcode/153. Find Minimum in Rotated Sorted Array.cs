﻿// Leetcode
// 153. Find Minimum in Rotated Sorted Array

class Solution
{
    public:
    int findMin(vector<int>& nums)
    {
        int l = 0;
        int r = nums.size() - 1;
        while (l < r)
        {
            int m = (r + l - 1) / 2;
            if (nums[m] <= nums[r])
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }
        return nums[l];
    }
};