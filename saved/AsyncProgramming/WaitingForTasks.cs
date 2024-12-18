// using System.Timers;

// namespace TaskCancellation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Task task1 = new(() =>
//             {
//                 Console.WriteLine("Task 1 started.");
//                 Console.WriteLine("Task 1 running ...");
//                 Thread.Sleep(2000);
//                 Console.WriteLine("Task 1 finished.");
//             });
//             task1.Start();
//             task1.Wait();

//             Task task2 = new(() =>
//             {
//                 Console.WriteLine("Task 2 started.");
//                 Console.WriteLine("Task 2 running ...");
//                 Thread.Sleep(6000);
//                 Console.WriteLine("Task 2 finished.");
//             });
//             task2.Start();

//             Task task3 = new(() =>
//             {
//                 Console.WriteLine("Task 3 started.");
//                 Console.WriteLine("Task 3 running ...");
//                 Thread.Sleep(500);
//                 Console.WriteLine("Task 3 finished.");
//             });
//             task3.Start();

//             // program will run until the specified tasks are complete
//             Task.WaitAll(task1, task2, task3);
//         }
//     }
// }
