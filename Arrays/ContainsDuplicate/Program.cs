

int[] nums = [3,3];

static bool ContainsDuplicate(int[] nums) {
    if(nums.Length == 0 || nums.Length == 1)
        return false;

    HashSet<int> uniques = new();
    
    foreach(int number in nums)
    {
        if(!uniques.Add(number))
            return true;
    }

    return false;
}

Console.WriteLine($"Array: {string.Join(", ", nums)} has Duplicate is: {ContainsDuplicate(nums)}");