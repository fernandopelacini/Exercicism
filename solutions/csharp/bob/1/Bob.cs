public static class Bob
{
    public static string Response(string statement)
    {
        string trimmed = statement.Trim();
    
        if (string.IsNullOrEmpty(trimmed))
        {
            return "Fine. Be that way!";
        }
    
        bool hasLetters = trimmed.Any(char.IsLetter);
        bool isYelling = hasLetters && trimmed.Where(char.IsLetter).All(char.IsUpper);
    
        
        bool isQuestion = trimmed.EndsWith('?');
    
        // 5. Match Bob's attitude to the input state
        if (isYelling && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }
        if (isYelling)
        {
            return "Whoa, chill out!";
        }
        if (isQuestion)
        {
            return "Sure.";
        }
    
        return "Whatever.";
    }
}