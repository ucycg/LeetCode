string[] strs = ["flower","flow","flight"];

static string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0) return string.Empty;
    if (strs.Length == 1) return strs[0];

    char[] prefix = strs[0].ToCharArray();
    char[][] words = new char[200][];

    for(int i = 0; i < strs.Length; i++)
    {
        words[i] = strs[i].ToCharArray();
    }

    for(int i = 0; i < prefix.Length; i++)
    {
        for(int j = 0; j < strs.Length; j++)
        {
            if (i == words[j].Length || words[j][i] != prefix[i])
            {
                return strs[j][..i];
            }
        }
    }
    return strs[0];
}

Console.WriteLine(LongestCommonPrefix(strs));