// using System.Timers;

// namespace CheckingTaskStatus
// {
//     class Program
//     {
//         static System.Timers.Timer? timer;
//         static Task? task;

//         static void Main(string[] args)
//         {
//             task = new(() =>
//             {
//                 for (int i = 1; i < 1_000_000_000; i++)
//                 {
//                     // Console.WriteLine(i);
//                 }
//             });

//             task.Start();

//             timer = new();
//             timer.Elapsed += CheckTheTask!;
//             timer.Interval = 1000;
//             timer.Enabled = true;

//             Console.ReadLine();
//         }

//         public static void CheckTheTask(object sender, ElapsedEventArgs e)
//         {
//             string text = task?.Status switch
//             {
//                 TaskStatus.Running => "Task is running!",
//                 TaskStatus.RanToCompletion => "Task is complete!",
//                 TaskStatus.Faulted => "Task was failed!",
//                 _ => "undefined",
//             };

//             if (text.Contains("complete", StringComparison.OrdinalIgnoreCase) && timer != null)
//             {
//                 timer.Enabled = false;
//             }
//             Console.WriteLine(text);
//         }
//     }
// }
