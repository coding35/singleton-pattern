namespace SingletonPattern.Singleton;

/*
* Lazy initialization. The alternative is to
 * eagerly initialize the singleton on creation.
 * The downside of lazy initialization is that
 * it is not thread-safe without additional
 * synchronization.
*/
public class LazySingletonNotThreadSafe
{
    private static LazySingletonNotThreadSafe? _instance;
    private readonly string _randomString;

    private LazySingletonNotThreadSafe()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static LazySingletonNotThreadSafe? GetInstance()
    {
        return _instance ??= new LazySingletonNotThreadSafe();
    }

    public void Print()
    {
        Console.WriteLine($"Lazy Not Thread Safe Singleton: {_randomString}");
    }
}