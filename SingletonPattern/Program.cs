using System.Diagnostics;
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