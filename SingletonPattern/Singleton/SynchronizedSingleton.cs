namespace SingletonPattern.Singleton;

/*
 * Double checked locking. The alternative is to
 * synchronize the entire method, but this is
 * expensive and unnecessary once the singleton
 * has been initialized.
 */
public class SynchronizedSingleton
{
    private static volatile SynchronizedSingleton? _instance;
    private readonly string _randomString;

    private SynchronizedSingleton()
    {
        _randomString = Guid.NewGuid().ToString();
    }
    
    public static SynchronizedSingleton? GetInstance()
    {
        if (_instance == null)
        {
            lock (typeof(SynchronizedSingleton))
            {
                if (_instance == null)
                {
                    _instance = new SynchronizedSingleton();
                }
            }
        }

        return _instance;
    }
    
    public void Print()
    {
        Console.WriteLine($"Synchronized Singleton: {_randomString}");
    }
}