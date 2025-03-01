// Leetcode
// 771. Jewels and Stones

class Solution
{
    public:
    int numJewelsInStones(string jewels, string stones)
    {
        unordered_set<char> jewels_hash;
        for (char c : jewels)
        {
            jewels_hash.insert(c);
        }
        int jewels_cnt = 0;
        for (char c : stones)
        {
            jewels_cnt += jewels_hash.count(c);
        }
        return jewels_cnt;
    }
};