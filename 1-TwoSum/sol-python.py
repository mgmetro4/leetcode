"""
Leet Code Solution
1. Two Sum (Easy)
Python3
"""

class Solution:
    def twoSum(self, nums, target):
        seen = {}
        for i, v in enumerate(nums):
            remaining = target - v
            if remaining in seen:
                return [seen[remaining], i]

            seen[v]=i