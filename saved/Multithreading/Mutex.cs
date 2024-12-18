// namespace MutexLesson
// {
//     class Program
//     {
//         private static readonly Mutex mut = new();

//         static void Main(string[] args)
//         {
//             for (int i = 0; i < 3; i++)
//             {
//                 Thread thread = new(
//                     new ThreadStart(() =>
//                     {
//                         for (int d = 0; d < 1; d++)
//                         {
//                             UseResource();
//                         }
//                     })
//                 );
//                 thread.Name = string.Format("(Thread no. {0})", i + 1);
//                 thread.Start();
//             }
//         }

//         private static void UseResource()
//         {
//             Console.WriteLine($"{Thread.CurrentThread.Name} is requsting mutex.");
//             mut.WaitOne();

//             Console.WriteLine($"{Thread.CurrentThread.Name} has entered a critical section.");
//             Thread.Sleep(2000);
//             Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the critical section.");

//             mut.ReleaseMutex();
//             Console.WriteLine($"{Thread.CurrentThread.Name} has released the mutex");
//         }
//     }
// }
