// Leetcode
// 350. Intersection of Two Arrays II

class Solution
{
    public:
    vector<int> intersect(vector<int>& nums1, vector<int>& nums2)
    {
        vector<int> ans;
        unordered_map<int, int> numbers_map_1;
        unordered_map<int, int> numbers_map_2;
        for (auto c : nums1)
        {
            ++numbers_map_1[c];
        }
        for (auto c : nums2)
        {
            if (numbers_map_1[c])
            {
                ans.push_back(c);
                --numbers_map_1[c];
            }
        }
        return ans;
    }
};