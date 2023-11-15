
#nullable enable

// Not thread safe. Multiple threads could create multiple instances. Could cause performance issues or bugs.
public sealed class BasicSingleton
{
    private static BasicSingleton? _instance;
    private static string? _randomString;

    public static BasicSingleton Instance
    {
        get
        {
            return _instance ??= new BasicSingleton();
        }
    }

    // private constructor
    private BasicSingleton()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static void Print()
    {
        Console.WriteLine($"Basic Singleton: {_randomString}");
    }
}
