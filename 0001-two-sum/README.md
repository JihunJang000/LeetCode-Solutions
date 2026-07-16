整数の配列 nums と整数 target が与えられたとき、それらの和が target になるような2つの数のインデックスを返します。

各入力には正確に1つの解が存在すると仮定してもよく、同じ要素を2 回使用してはいけません。

答えは、どの順番で返しても構いません。

 

例 1：

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
例 2：

Input: nums = [3,2,4], target = 6
Output: [1,2]
例 3：

Input: nums = [3,3], target = 6
Output: [0,1]
 

制約条件：

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
有効な答えは1つだけです。
