namespace SingletonPattern.Singleton;

/*
* Lazy initialization. The alternative is to
 * eagerly initialize the singleton on creation.
 * The downside of lazy initialization is that
 * it is not thread-safe without additional
 * synchronization.
*/
public class LazySingleton
{

    private static LazySingleton? _instance;
    private readonly string _randomString;

    private LazySingleton()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static LazySingleton? GetInstance()
    {
        return _instance ??= new LazySingleton();
    }

    public void Print()
    {
        Console.WriteLine($"Lazy Singleton: {_randomString}");
    }
}