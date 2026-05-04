
using System.IO.Pipelines;

int[] nums = [2,7,11,15];
    int target = 9;
    
    static int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++ )
            {
                if( nums[i] + nums[j] == target)
                {
                    int[] result = {i,j};
                    return result;
                }
            }
        }
        return null;
    }

    static int[] TwoSumDict(int[] nums, int target) 
    {
        Dictionary<int,int> SeenNums  = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            // cur + x = target
            int x = target - nums[i];
            if(SeenNums.TryGetValue(x,out int value))
                return [value, i];
            SeenNums.TryAdd(nums[i],i);
        }
        return null;
    }

    Console.WriteLine($"Indices brute force: {string.Join(", ",TwoSum(nums,target))}");

    Console.WriteLine($"Indices with Dictionary: {string.Join(", ",TwoSumDict(nums,target))}");
    

