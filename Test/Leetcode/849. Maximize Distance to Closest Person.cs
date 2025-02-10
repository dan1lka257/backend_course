// Leetcode
// 849. Maximize Distance to Closest Person

class Solution
{
    public:
    int maxDistToClosest(vector<int>& seats)
    {
        int l = 0, max_dist = 0;
        for (int i = 0; i < seats.size(); ++i)
        {
            if (seats[i])
            {
                l = i;
                max_dist = l;
                break;
            }
        }
        for (int i = 0; i < seats.size(); ++i)
        {
            if (seats[seats.size() - 1 - i])
            {
                max_dist = max(max_dist, i);
                break;
            }
        }
        for (int i = l + 1; i < seats.size(); ++i)
        {
            max_dist = max(max_dist, (i - l) / 2);
            if (seats[i])
            {
                l = i;
            }
        }
        return max_dist;
    }
};