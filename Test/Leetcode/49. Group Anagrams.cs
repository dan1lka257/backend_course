// Leetcode
// 49. Group Anagrams

class Solution
{
    public:
    vector<vector<string>> groupAnagrams(vector<string>& strs)
    {
        unordered_map<string, vector<string>> anagrams;
        for (string s : strs)
        {
            string key = s;
            sort(key.begin(), key.end());
            anagrams[key].push_back(s);
        }
        vector<vector<string>> ans;
        for (auto & anagram : anagrams)
        {
            ans.push_back(anagram.second);
        }
        return ans;
    }
};