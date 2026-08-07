public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
          foreach (var item in collection)
  {
      if (item != null)
      {
          yield return func(item);
      }
  }
    }
}