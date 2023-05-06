namespace SingletonPattern.Singleton;

/*
 * Singleton using an enum. This is thread-safe and
 * does not require synchronization. It is the preferred
 * approach for implementing singletons.
 */
public sealed class EnumSingleton
{
    private static string? _randomString;

    private EnumSingleton()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static EnumSingleton Instance
    {
        get
        {
            return InnerSingleton.Instance;
        }

    }

    public void Print()
    {
        Console.WriteLine($"Enum Singleton: {_randomString}");
    }

    private class InnerSingleton
    {
        static InnerSingleton()
        {
        }

        internal static readonly EnumSingleton Instance = new EnumSingleton();
    }
}