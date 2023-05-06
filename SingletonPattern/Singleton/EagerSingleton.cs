namespace SingletonPattern.Singleton;

public class EagerSingleton
{
    /*
     * Eager initialization. The alternative is lazy initialization
     * whereby initialization is deferred until the first time the
     * singleton is used.
     */
    private static readonly EagerSingleton Instance = new EagerSingleton();
    private readonly string _randomString;

    private EagerSingleton()
    {
        _randomString = Guid.NewGuid().ToString();
    }
    
    public static EagerSingleton GetInstance()
    {
        return Instance;
    }

    public void Print()
    {
        Console.WriteLine($"Eager Singleton: {_randomString}");
    }
}