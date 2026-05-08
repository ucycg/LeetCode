
string[] words = ["abba","baba","bbaa","cd","cd"];

static List<string> RemoveAnagrams(string[] words)
{
    List<string> CleanWords = [.. words];
    if(words.Length == 0 || words.Length == 1)
        return CleanWords;
    else
    {
        for(int i = 1; i < CleanWords.Count; i++)
        {
            while(isAnagram(CleanWords.ElementAt(i-1), CleanWords.ElementAt(i)))
            {
                CleanWords.RemoveAt(i);
                if(i == CleanWords.Count)
                    break;
            }
        }
    }
    return CleanWords;
}

static bool isAnagram(string firstWord, string secondWord)
{
    if(firstWord.Length == secondWord.Length)
    {
        int[] firstWordLettersCount = new int[26];
        int[] secondWordLettersCount = new int[26];

        foreach(char letter in firstWord)
        {
            firstWordLettersCount[letter - 'a']++; //
        }
        foreach(char letter in secondWord)
        {
            secondWordLettersCount[letter - 'a']++;
        }
        for(int i = 0; i < firstWordLettersCount.Length; i++)
        {
            if(firstWordLettersCount[i] != secondWordLettersCount[i])
                return false; 
        }
        return true;
    }
    else 
        return false;
}

Console.WriteLine($"[{string.Join(',',RemoveAnagrams(words))}]");