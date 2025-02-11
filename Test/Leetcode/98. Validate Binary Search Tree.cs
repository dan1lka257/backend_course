// Leetcode
// 98. Validate Binary Search Tree

/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution
{

    bool isPossible(TreeNode* root, int64_t l, int64_t r)
    {
        if (root == nullptr) return true;
        if (root->val < r and root->val > l)
        return isPossible(root->left, l, root->val) && isPossible(root->right, root->val, r);
    else return false;
    }

    public:
    bool isValidBST(TreeNode* root)
    {
        int64_t min = -2147483649, max = 2147483648;
        return isPossible(root, min, max);
    }
};