namespace Music.Bogus;

internal static class Guard
{
    internal static void AgainstNegative(int value, string argumentName)
    {
        if (value < 0)
        {
            throw new ArgumentNullException(argumentName);
        }
    }
}