
#nullable enable

// Not thread safe. Multiple threads could create multiple instances. Could cause performance issues or bugs.
public sealed class BasicSingletonThreadSafe
{
    private static BasicSingletonThreadSafe? _instance;
    private static string? _randomString;
    private static readonly object _lock = new object(); // make sure this is always private and not shared.

    public static BasicSingletonThreadSafe Instance
    {
        get
        {
            // Ensures only one thread can access this block of code at a time. 
            // Instance synchronization and thread safety but adds overhead because because 
            // the lock is used every time the instance is referenced.
            lock (_lock) 
            {
                return _instance ??= new BasicSingletonThreadSafe();
            }
        }
    }

    // private constructor
    private BasicSingletonThreadSafe()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static void Print()
    {
        Console.WriteLine($"Basic SingletonThreadSafeLocking : {_randomString}");
    }
}
