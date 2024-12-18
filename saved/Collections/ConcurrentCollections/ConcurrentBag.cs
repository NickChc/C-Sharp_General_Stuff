// using System.Collections.Concurrent;
// using System.Threading;

// namespace BlockingCollection
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // If List<int> is used instead, it could lead to corrupted data or race conditions !
//             ConcurrentBag<int> bag = [];

//             Thread t1 = new(() =>
//             {
//                 Console.WriteLine("Thread (1) has started.");
//                 for (int i = 1; i <= 10; i++)
//                 {
//                     Console.WriteLine("THread (1) added number " + i);
//                     bag.Add(i);
//                 }
//                 Console.WriteLine("Thread (1) is complete!");
//             });

//             Thread t2 = new(() =>
//             {
//                 Console.WriteLine("Thread (2) has started.");
//                 for (int i = 11; i <= 25; i++)
//                 {
//                     bag.Add(i);
//                     Console.WriteLine("THread (2) added number " + i);
//                 }
//                 Console.WriteLine("Thread (2) is complete!");
//             });

//             Thread t3 = new(() =>
//             {
//                 t1.Join();
//                 t2.Join();

//                 foreach (var item in bag)
//                 {
//                     Console.WriteLine(item);
//                 }
//                 Console.WriteLine("Thread (3) is complete!");
//             });

//             t1.Start();
//             t2.Start();
//             t3.Start();
//         }
//     }
// }
