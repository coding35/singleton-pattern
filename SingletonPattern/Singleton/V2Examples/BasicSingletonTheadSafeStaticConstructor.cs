
#nullable enable

// Not thread safe. Multiple threads could create multiple instances. Could cause performance issues or bugs.
public sealed class BasicSingletonTheadSafeStaticConstructor
{
    private static BasicSingletonTheadSafeStaticConstructor _instance = new();
    private static string? _randomString;

    public static BasicSingletonTheadSafeStaticConstructor Instance
    {
        get
        {
            return Nested.instance;
        }
    }

    // static constructor
    // Tells C# compiler not to mark type as beforefieldinit
    // https://csharpindepth.com/articles/BeforeFieldInit
    static BasicSingletonTheadSafeStaticConstructor()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static void Print()
    {
        Console.WriteLine($"Basic Singleton ThreadSafe With Static Constructor: {_randomString}");
    }

    private class Nested{
        static Nested() { }
        internal static readonly BasicSingletonTheadSafeStaticConstructor instance = new BasicSingletonTheadSafeStaticConstructor();
    }
}
