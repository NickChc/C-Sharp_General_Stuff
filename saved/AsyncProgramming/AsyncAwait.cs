// namespace AsyncAwait
// {
//     class Program
//     {
//         static readonly string processGetDataFromDatabase = "(Getting data from DB)";

//         static void Main(string[] args)
//         {
//             Console.WriteLine("First we are inside the Main method");
//             RunProcess(1, 1_000_000);

//             var dbTask = ConnectToDatabaseAndGetData();
//             Console.WriteLine("\nBack to the main method.");
//             if (dbTask.Status == TaskStatus.RanToCompletion)
//             {
//                 Console.WriteLine($"Process {processGetDataFromDatabase} is completed");
//             }
//             else
//             {
//                 Console.WriteLine($"Process {processGetDataFromDatabase} is NOT completed yet.");
//             }

//             RunProcess(2, 1_000_000);

//             Console.ReadLine();
//         }

//         public static async Task ConnectToDatabaseAndGetData()
//         {
//             Console.WriteLine($"\nControl is with process {processGetDataFromDatabase}");
//             Console.WriteLine($"Process {processGetDataFromDatabase} has started.");
//             Console.WriteLine($"Process {processGetDataFromDatabase} is running ...");

//             await Task.Run(() =>
//             {
//                 Console.WriteLine("Start executing process in await section.");
//                 Thread.Sleep(5000);
//                 RunProcess(3, 100_000);
//                 Console.WriteLine("The process in await section is complete.");
//             });
//             Console.WriteLine($"Process {processGetDataFromDatabase} is complete!");
//             Console.WriteLine($"\nControl is with {processGetDataFromDatabase} again.");
//             for (int i = 0; i < 10; i++)
//             {
//                 Console.WriteLine("Getting data...");
//             }
//             Console.WriteLine($"Process {processGetDataFromDatabase} is complete!");
//         }

//         private static void RunProcess(int processNumber, int processLoopCondition)
//         {
//             Console.WriteLine("\nControl is with process - " + processNumber);
//             Console.WriteLine($"Process ({processNumber}) has started.");
//             Console.WriteLine($"Process ({processNumber}) is running ...");
//             for (int i = 0; i < processLoopCondition; i++)
//                 ;
//             Console.WriteLine($"Process ({processNumber}) is complete.");
//             Console.WriteLine("\nControl is back to Main method.");
//         }
//     }
// }
