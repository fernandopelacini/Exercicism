public class Anagram
{
        private readonly string _targetWord;
    private readonly string _normalizedTarget;

    public Anagram(string baseWord)
    {
         if (baseWord == null)
 {
     throw new ArgumentNullException(nameof(baseWord));
 }

 _targetWord = baseWord.ToLowerInvariant();
 _normalizedTarget = Normalize(_targetWord);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
         if (potentialMatches == null)
 {
     return Array.Empty<string>();
 }

 var matches = new List<string>();

 foreach (var candidate in potentialMatches)
 {
     if (candidate == null) continue;

     string candidateLower = candidate.ToLowerInvariant();

     if (candidateLower == _targetWord)
     {
         continue;
     }

     
     if (candidateLower.Length != _targetWord.Length)
     {
         continue;
     }

     if (Normalize(candidateLower) == _normalizedTarget)
     {
         matches.Add(candidate);
     }
 }

 return matches.ToArray();
    }

      private string Normalize(string word)
  {
      char[] chars = word.ToCharArray();
      Array.Sort(chars);
      return new string(chars);
  }
}