using System.Collections.Generic;

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        var verses = new List<string>();

        var numberToText = new Dictionary<int, string>
        {
            {1, "One" },
            { 2, "Two" },
            { 3, "Three" },
            { 4, "Four" },
            { 5, "Five" },
            { 6, "Six" },
            {7, "Seven" },
            {8, "Eight" },
            {9, "Nine" },
            {10, "Ten" }
        };

        do
        {
           if (verses.Count > 0)
            {
                verses.Add(string.Empty);
            }
            switch (startBottles)
            {
                case 0:
                    verses.Add("There'll be no green bottles hanging on the wall.");
                    break;
                case 1:
                    verses.Add("One green bottle hanging on the wall,");
                    verses.Add("One green bottle hanging on the wall,");
                    verses.Add("And if one green bottle should accidentally fall,");
                    verses.Add("There'll be no green bottles hanging on the wall.");
                    break;
case 2:
    verses.Add("Two green bottles hanging on the wall,");
    verses.Add("Two green bottles hanging on the wall,");
    verses.Add("And if one green bottle should accidentally fall,");
    verses.Add("There'll be one green bottle hanging on the wall.");
    break;

                default:
                    verses.Add($"{numberToText[startBottles]} green bottles hanging on the wall,");
                    verses.Add($"{numberToText[startBottles]} green bottles hanging on the wall,");
                    verses.Add($"And if one green bottle should accidentally fall,");
                    verses.Add($"There'll be {numberToText[startBottles - 1].ToLower()} green bottles hanging on the wall.");
                    break;
            }
        } 
        
        while (--startBottles >= 0 && --takeDown > 0) ;
        return verses;
    }
}
