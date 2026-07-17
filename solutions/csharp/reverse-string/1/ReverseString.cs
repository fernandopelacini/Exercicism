public static class ReverseString
{
    public static string Reverse(string input)
    {
          var reversed = input.ToArray().Reverse();
          return new string(reversed.ToArray());
    }
}