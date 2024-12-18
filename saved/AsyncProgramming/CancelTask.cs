// using System.Timers;

// namespace TaskCancellation
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             CancellationTokenSource cts = new();
//             CancellationToken token = cts.Token;

//             Task task = new(() =>
//             {
//                 for (int i = 0; i < 100_000; i++)
//                 {
//                     if (cts.IsCancellationRequested)
//                     {
//                         Console.ForegroundColor = ConsoleColor.Red;
//                         Console.WriteLine("Task was cancelled");
//                         Console.ResetColor();
//                         return;
//                     }

//                     Console.WriteLine(i + 1);
//                 }
//                 Console.WriteLine("TASK IS COMPLETE");
//             });

//             task.Start();

//             Thread.Sleep(3000);
//             cts.Cancel();
//             Console.ReadLine();
//         }
//     }
// }
