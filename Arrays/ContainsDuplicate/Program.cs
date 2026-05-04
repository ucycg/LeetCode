

int[] nums = [3,3];

static bool ContainsDuplicate(int[] nums) {
    if(nums.Length == 0 || nums.Length == 1)
        return false;

    int[] uniques = new int[nums.Length];

    for(int i = 0; i < nums.Length; i++)
    {
        for(int j = 0; j < i; j++)
        {
            if(nums[i] == uniques[j])
            {
                return true;
            }
        }
        uniques[i] = nums[i];
    }
    return false;
}

Console.WriteLine($"Array: {string.Join(", ", nums)} has Duplicate is: {ContainsDuplicate(nums)}");