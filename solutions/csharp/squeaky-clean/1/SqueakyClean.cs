using System;
using System.Text;
public static class Identifier
{
  private static bool containsGreekCharacters(char c) => (c >= 'α' && c <= 'ω');
        public static string Clean(string identifier)
        {
           StringBuilder newStr = new StringBuilder();
            bool isKebab = false;
        
            foreach (char character in identifier)
            { 
                if (char.IsWhiteSpace(character)) {
                    newStr.Append("_");
                }
                else if (char.IsControl(character))
                {
                    newStr.Append("CTRL");
                }
                else if (char.IsPunctuation(character)) 
                {
                    newStr.Append(string.Empty);
                    isKebab = true;
                }
                else if (containsGreekCharacters(character))
                {
                    newStr.Append(string.Empty);
                }    
                else if (char.IsNumber(character))
                {
                    newStr.Append(string.Empty);
                }
                else if (char.IsLetter(character))
                {
                    if (isKebab)
                    {
                    newStr.Append(char.ToUpper(character));
                        isKebab = false;
                    }
                    else
                    {
                        newStr.Append(character);
                    }
                }
            }
            return newStr.ToString();
        }
        
}
