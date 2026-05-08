
string[] words = ["abba","baba","bbaa","cd","cd"];

static List<string> RemoveAnagrams(string[] words)
{
    List<string> cleanWords = [.. words];
    if(words.Length == 0 || words.Length == 1)
        return cleanWords;
    else
    {
        for(int i = 1; i < cleanWords.Count; i++)
        {
            while(isAnagram(cleanWords[i-1], cleanWords[i]))
            {
                cleanWords.RemoveAt(i);
                if(i == cleanWords.Count)
                    break;
            }
        }
    }
    return cleanWords;
}

static bool isAnagram(string firstWord, string secondWord)
{
    if(firstWord.Length == secondWord.Length)
    {
        int[] lettersCount = new int[26];

        for(int i = 0; i < firstWord.Length; i++)
        {
            lettersCount[ firstWord[i] - 'a']++;
            lettersCount[ secondWord[i] - 'a']--;
        }

        foreach(int count in lettersCount)
        {
            if(count != 0)
                return false; 
        }
        return true;
    }
    else 
        return false;
}

Console.WriteLine($"[{string.Join(',',RemoveAnagrams(words))}]");