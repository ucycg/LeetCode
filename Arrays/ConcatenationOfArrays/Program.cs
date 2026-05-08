int[] nums = [1,2,1];

static int[] GetConcatenation(int[] nums)
{
    int[] concatNums = new int[2*nums.Length];
    for(int i = 0; i < nums.Length; i++)
    {
        concatNums[i] = nums[i];
        concatNums[nums.Length + i] = nums[i];
    }
    return concatNums;
}

Console.WriteLine(string.Join(",", GetConcatenation(nums)));