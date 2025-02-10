﻿// Leetcode
// 206. Reverse Linked List

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
    ListNode* reverseList(ListNode* head)
    {
        ListNode* prev_node = nullptr;
        ListNode* curr_node = head;
        ListNode* next_node;
        if (curr_node != nullptr)
        {
            next_node = curr_node->next;
        }
        while (curr_node != nullptr)
        {
            curr_node->next = prev_node;

            prev_node = curr_node;
            curr_node = next_node;
            if (next_node != nullptr)
            {
                next_node = next_node->next;
            }
        }
        return prev_node;
    }
};