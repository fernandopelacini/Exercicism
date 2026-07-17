public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
       string plaintext = "abcdefghijklmnopqrstuvwxyz";
       string ciphertext ="";
        
       for (int i = 0; i < text.Length; i++)
        {
           if (!char.IsLetter(text[i]))
            {
                ciphertext += text[i];
                continue;
            }
           var character = plaintext.IndexOf(char.ToLower(text[i])) + shiftKey;
          if (character >= plaintext.Length)
          {
              character = character - plaintext.Length;
          }
        
          string temp = plaintext.Substring(character, 1);
          ciphertext +=   char.IsUpper(text[i]) ? temp.ToUpper() : temp;
        }
        
        Console.WriteLine($"Ciphertext alphabet: {ciphertext}");
        return ciphertext;
    }
}