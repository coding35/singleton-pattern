
// no null checking or locking required.
// the return _lazy.Value is thread safe and guaranteed to never be null and executed only once.

public sealed class LazyOfTSingleton
{
    public static readonly Lazy<LazyOfTSingleton> _lazy = new Lazy<LazyOfTSingleton>(() => new LazyOfTSingleton());
    private static string? _randomString;


    public static LazyOfTSingleton Instance
    {
        get
        {
            return _lazy.Value;
        }
    }

    private LazyOfTSingleton()
    {
        _randomString = Guid.NewGuid().ToString();
    }

    public static void Print()
    {
        Console.WriteLine($"Basic Singleton ThreadSafe Lazy of T: {_randomString}");
    }
}