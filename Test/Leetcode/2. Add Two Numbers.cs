// Leetcode
// 2. Add Two Numbers

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution
{
    public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2)
    {
        int remain = 0;
        ListNode* ans = l1;
        while (l1 != nullptr || l2 != nullptr)
        {
            int l2_val = l2 == nullptr ? 0 : l2->val;
            int new_remain = (l1->val + l2_val + remain) / 10;
            l1->val = (l1->val + l2_val + remain) % 10;
            remain = new_remain;
            if (l1->next == nullptr && (remain != 0 || (l2 != nullptr && l2->next != nullptr)))
            {
                l1->next = new ListNode();
            }
            l1 = l1->next;
            l2 = l2 == nullptr ? l2 : l2->next;
        }

        return ans;
    }
};