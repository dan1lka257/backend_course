// Leetcode
// 150. Evaluate Reverse Polish Notation

class Solution
{
    public:
    int evalRPN(vector<string>& tokens) {
        stack<int> st;
        for (auto s : tokens) {
            try {
                st.push(std::stoi(s));
            }
            catch (...) {
                int x = st.top();
                st.pop();
                int y = st.top();
                st.pop();
                if (s == "+") {
                    st.push(y + x);
                }
                else if (s == "-") {
                    st.push(y - x);
                }
                else if (s == "/") {
                    st.push(y / x);
                }
                else if (s == "*") {
                    st.push(y * x);
                }
            }
        }
        return st.top();
    }
};