using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Examp1
{
    public class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(10);
            }
        }

        public static void ThreadMethod1(object o)
        {
            if (o!=null)
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        class Test
        {
            int[] _array;
            public Test()
            {
                Console.WriteLine("Test()");
                _array = new int[10];
            }
            public int Length
            {
                get
                {
                    return _array.Length;
                }
            }
        }

        public static void Main(string[] args)
        {
            //Task<Int32[]> parent = Task.Run(() =>
            //{
            //    var results = new Int32[3];
            //    TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,  TaskContinuationOptions.ExecuteSynchronously);
            //    tf.StartNew(() => results[0] = 0);
            //    tf.StartNew(() => results[1] = 1);
            //    tf.StartNew(() => results[2] = 2);
            //    return results;
            //});

            //    var finalTask = parent.ContinueWith(
            //                    parentTask => {
            //                                    foreach (int i in parentTask.Result)
            //                                             Console.WriteLine(i);
            //                                  });
            //    finalTask.Wait();

            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });


            Lazy<Test> lazy = new Lazy<Test>();
                Test t = lazy.Value;

            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("Rabbit", 4));
            list.Add(new KeyValuePair<string, int>("Cat", 1));
            list.Add(new KeyValuePair<string, int>("Cat", 1));
            list.Add(new KeyValuePair<string, int>("Dog", 2));

            list.Sort((KeyValuePair<string, int> x, 
                       KeyValuePair<string, int> y) => {
                                                        return x.Key.CompareTo(y.Key);
                                                       });






            //    Task<Int32[]> parent = Task.Run(() =>
            //    {
            //        var results = new Int32[3];
            //        new Task( () => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
            //        new Task( () => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
            //        new Task( () => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
            //        return results;
            //    });

            //    var finalTask = parent.ContinueWith(parentTask => {
            //                                        foreach (int i in parentTask.Result)
            //                                                 Console.WriteLine(i);
            //                                        });
            //    finalTask.Wait();



            //Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //});

            //t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Canceled");
            //}, TaskContinuationOptions.OnlyOnCanceled);

            //t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Faulted");
            //}, TaskContinuationOptions.OnlyOnFaulted);

            //var completedTask = t.ContinueWith((i) =>
            //{
            //    Console.WriteLine("Completed");
            //}, TaskContinuationOptions.OnlyOnRanToCompletion);

            //completedTask.Wait();


            //Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //}).ContinueWith((i) =>
            //{
            //    return i.Result * 2;
            //});


            //Task<int> t = Task.Run(() =>
            //{
            //    return 42;
            //});
            //Console.WriteLine(t.Result); // Displays 42


            //ThreadPool.QueueUserWorkItem((s) =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine($"Working on a thread from threadpool{s}");

            //    }

            //});
            //Console.ReadLine();

            //Task[] ttt = new Task[2];

            //for (int i = 0; i < ttt.Length; i++)
            //{
            //    ttt[i] = Task.Run(() =>
            //                {
            //                    Thread.Sleep(1000);
            //                    Console.WriteLine($"This is value{i}:"+ Thread.CurrentThread.ManagedThreadId);
            //                });                
            //}

            //Task.WaitAll(ttt); 



            //Thread t = new Thread(new ThreadStart(() =>
            //{
            //    while (!stopped)
            //    {
            //        Console.WriteLine("Running...");
            //        Thread.Sleep(1000);
            //    }
            //}));

            //t.Start();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
            //stopped = true;
            //t.Join();


            //Thread[] lt = new Thread[10000];
            //Thread t;
            //foreach (var item in lt)
            //{
            //    t = new Thread(new ThreadStart(ThreadMethod));
            //    t.Start();
            //}

            //Thread t = new Thread(new ThreadStart(ThreadMethod));
            //Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod1));
            //t.Start(5);
            //t.Abort();


            //Thread t1 = new Thread(new ThreadStart(ThreadMethod));
            //t1.IsBackground = true;
            //t1.Start();
            //t1.Join();
        }
    }
}
        // 1st example
        //Thread t = new Thread(new ThreadStart(ThreadMethod));
        //t.Start();
        //for (int i = 0; i < 4; i++)
        //{
        //    Console.WriteLine("Main thread: Do some work now.");
        //    Thread.Sleep(10);
        //}
        //t.Join();
        //Console.WriteLine("Exit now");
        //Console.ReadLine();    

