### What is an Array?
* An array is a collection of elements of same data type with fixed size.
* Each element is accessed by index. O(1)
* It's contiguous blok of Memory

### Key Characteristics
* Fixed size
* Random access via index O(1)
* Insertion/Deletion at middle of the array O(n). (Because elements needs to shift)

### When to use
* When you know the number of elements in advance
* Need fast index based access. o(1)
* Don't need frequent insertions or deletions.

## Coding Problems
1. Find the maximum number in an array.

📝 Problem: Find the Maximum Element in an Array
Write a method that returns the largest number in an integer array. Assume the array has at least one element.

```
//Method Signature
public int FindMax(int[] nums)

Input:  [3, 7, 2, 9, 4]
Output: 9
```

```
//Solution

 public int FindMax(int[] nums)
 {
     int max = nums[0];
     foreach (int item in nums)  //O(n)
     {
         if (item > max) max = item;
     }
     return max;
 }
 ```

 2. Check for Duplicates in an Array.

 #### Problem Statement:
Given an integer array nums, return true if any value appears at least twice, and return false if every element is distinct.

```
  public bool ContainsDuplicate(int[] nums)
  {
      HashSet<int> result = new HashSet<int>(nums); //O(n)
      return result.Count != nums.Length;
  }
  ```
  3. 🚀 Question: Longest Subarray with Sum = K

Problem Statement:

Given an array of integers nums and an integer k, return the length of the longest subarray whose sum equals k.

```
Input: nums = [1, -1, 5, -2, 3], k = 3  
Output: 4  
Explanation: The subarray [1, -1, 5, -2] sums to 3 and is the longest.

Input: nums = [-2, -1, 2, 1], k = 1  
Output: 2  
Explanation: The subarray [2, -1] has sum = 1.
```

### 🧠 Hints:

* Brute-force will work but is O(n²).
* Can you do it in O(n) using a HashMap?
* Think of prefix sums and storing the earliest occurrence of each sum.

```
  public int LongestSubarraySumEqualsK2(int[] nums, int k)
  {
      int maxLength = 0;
      int sum = 0;
      Dictionary<int,int> dict = new Dictionary<int,int>();
      dict[0] = -1;
      for(int i = 0; i < nums.Length; i++)
      {
          sum += nums[i];
          if(dict.ContainsKey(sum-k))
          {
              maxLength = Math.Max(maxLength, i - dict[sum-k]);
          }


          // Store only the first occurrence of this prefix sum
          if (!dict.ContainsKey(sum))
          {
              dict[sum] = i;
          }
      }
      return maxLength;
  }
```


