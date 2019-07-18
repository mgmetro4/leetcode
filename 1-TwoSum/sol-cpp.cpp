/*
*Leet Code Solution
*1. Two Sum (Easy)
*C++
*/


class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        std::unordered_map<int, int> num2id;
        for(int i=0; i < nums.size(); i++)
        {
            int res = target - nums[i];
            auto it = num2id.find(res);
            if(it != num2id.end()) return vector<int>{it->second, i};
            num2id[ nums[i] ] = i;
        }
        
        return vector<int>();
    }
};