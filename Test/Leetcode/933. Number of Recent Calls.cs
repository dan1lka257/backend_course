// Leetcode
// 933. Number of Recent Calls

class RecentCounter
{
    deque<int> recent_calls;
    int ctr;
    public:
    RecentCounter() : ctr(0) { }

    int ping(int t)
    {
        recent_calls.push_back(t);
        while (recent_calls[0] < t - 3000)
        {
            recent_calls.pop_front();
        }
        return recent_calls.size();
    }
};