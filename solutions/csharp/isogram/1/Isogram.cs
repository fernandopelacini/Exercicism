public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return true; // Consider empty string as an isogram
        }
        foreach (char c in word.ToLower())
        {
            if (char.IsLetter(c) && word.ToLower().Count(x => x == c) > 1)
            {
                return false;
            }
        }

        return true;
    }
}
