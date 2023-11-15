
#nullable enable

// Not thread safe. Multiple threads could create multiple instances. Could cause performance issues or bugs.
public sealed class BasicSingletonThreadSafeWithBetterLocking
{
    private static BasicSingletonThreadSafeWithBetterLocking? _instance;
    private static string? _randomString;
    private static readonly object _lock = new object(); // make sure this is always private and not shared.

    public static BasicSingletonThreadSafeWithBetterLocking Instance
    {
        get
        {
            // Ensures only one thread can access this block of code at a time. 
            // Instance synchronization is performed only when the instance is null.
            // This is known as double-checked locking and is a pattern designed to
            // reduce the overhead of acquiring a lock by first testing the locking
            // criterion (the _instance field) without obtaining the lock.
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new BasicSingletonThreadSafeWithBetterLocking();
                }
            }
            return _instance;
        }
    }

    // private constructor
    private BasicSingletonThreadSafeWithBetterLocking()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static void Print()
    {
        Console.WriteLine($"Basic Singleton ThreadSafe With Better Locking: {_randomString}");
    }
}
