using SingletonPattern.Singleton;

// eager initialization
var test = EagerSingleton.GetInstance();
test.Print();
var test2 = EagerSingleton.GetInstance();
test2.Print();

// lazy initialization
var test3 = LazySingleton.GetInstance();
test3!.Print();
var test4 = LazySingleton.GetInstance();
test4!.Print();

// lazy initialization not thread safe
var test5 = LazySingletonNotThreadSafe.GetInstance();
Thread thread1 = new Thread(new ThreadStart(test5!.Print));
Thread thread2 = new Thread(new ThreadStart(test5!.Print));

thread1.Start();
thread2.Start();

// thread safe. two threads accessing the same instance.
var test6 = SynchronizedSingleton.GetInstance();
Thread thread3 = new Thread(new ThreadStart(test6!.Print));
Thread thread4 = new Thread(new ThreadStart(test6!.Print));

thread3.Start();
thread4.Start();

//enum singleton. thread safe.
var test7 = EnumSingleton.Instance;
test7.Print();
var test8 = EnumSingleton.Instance;
test8.Print();


// **** V2 **** //
// V2 is a more modern approach to the singleton pattern.

var test9 = BasicSingleton.Instance;
BasicSingleton.Print();
var test10 = BasicSingleton.Instance;
BasicSingleton.Print();

var test11 = BasicSingletonThreadSafe.Instance;
BasicSingletonThreadSafe.Print();
var test12 = BasicSingletonThreadSafe.Instance;
BasicSingletonThreadSafe.Print();

var test13 = BasicSingletonThreadSafeWithBetterLocking.Instance;
BasicSingletonThreadSafeWithBetterLocking.Print();
var test14 = BasicSingletonThreadSafeWithBetterLocking.Instance;
BasicSingletonThreadSafeWithBetterLocking.Print();

var test15 = BasicSingletonTheadSafeStaticConstructor.Instance;
BasicSingletonTheadSafeStaticConstructor.Print();
var test16 = BasicSingletonTheadSafeStaticConstructor.Instance;
BasicSingletonTheadSafeStaticConstructor.Print();

var test17 = LazyOfTSingleton.Instance;
LazyOfTSingleton.Print();
var test18 = LazyOfTSingleton.Instance;
LazyOfTSingleton.Print();