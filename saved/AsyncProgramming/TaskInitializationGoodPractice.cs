// namespace AssignmentsFrom_18_to_22
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             CancellationTokenSource cts = new();
//             CancellationToken token = cts.Token;

//             Task<long> t1 = Task.FromResult(0L);
//             Task<long> t2 = Task.FromResult(0L);

//             t1 = new(() =>
//             {
//                 long res = 0;

//                 for (int i = 0; i < 1_000_000; i++)
//                 {
//                     if (cts.IsCancellationRequested)
//                     {
//                         return res;
//                     }

//                     res += i;
//                 }

//                 cts.Cancel();
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine(
//                     $"Task (1) cancelled task (2) while it was on value - {t2.Result}"
//                 );
//                 Console.ResetColor();
//                 return res;
//             });

//             t2 = new(() =>
//             {
//                 long res = 0;

//                 for (int i = 0; i < 1_000_000; i++)
//                 {
//                     if (cts.IsCancellationRequested)
//                     {
//                         return res;
//                     }

//                     res += i;
//                 }

//                 cts.Cancel();
//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine(
//                     $"Task (2) cancelled task (1) while it was on value - {t1.Result}"
//                 );
//                 Console.ResetColor();
//                 return res;
//             });

//             t1.Start();
//             t2.Start();

//             Task.WaitAll(t1, t2);
//         }
//     }
// }
