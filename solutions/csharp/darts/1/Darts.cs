public static class Darts
{
    public static int Score(double x, double y)
    {
       double distanceSquared = x * x + y * y;

        if (distanceSquared <= 1)
        {
            return 10;
        }
        if (distanceSquared <= 25)
        {
            return 5;
        }
        if (distanceSquared <= 100)
        {
            return 1;
        }

        return 0;
    }
}
