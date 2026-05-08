int[] nums = [1,2,1];

static int[] GetConcatenation(int[] nums)
{
    int[] concatNums = new int[2 * nums.Length];
    Span<int> targetSpan = concatNums.AsSpan();

    // Slice the target span into halves and copy the memory directly
    nums.CopyTo(targetSpan[..nums.Length]);
    nums.CopyTo(targetSpan.Slice(nums.Length, nums.Length));
    return concatNums;
}

Console.WriteLine(string.Join(",", GetConcatenation(nums)));