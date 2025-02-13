﻿// Leetcode
// 470. Implement Rand10() Using Rand7()

// The rand7() API is already defined for you.
// int rand7();
// @return a random integer in the range 1 to 7

class Solution
{
    public:
    int rand10()
    {
        int result = 40;
        while (result >= 40)
        {
            result = 7 * (rand7() - 1) + (rand7() - 1);
        }
        return result % 10 + 1;
    }
};