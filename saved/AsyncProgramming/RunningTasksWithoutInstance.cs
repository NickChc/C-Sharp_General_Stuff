// namespace RunningTasksWithoutInstance
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             SayHiTask();

//             AddNumbersTask(1, 2, 3, 12);

//             Console.ReadLine();
//         }

//         public static Task SayHiTask()
//         {
//             return Task.Run(() =>
//             {
//                 Console.WriteLine("Hi from task");
//             });
//         }

//         public static Task AddNumbersTask(params int[] numbers)
//         {
//             return Task.Run(() =>
//             {
//                 Console.WriteLine("Add numbers has started");

//                 int res = numbers.Aggregate((acc, curr) => acc + curr);

//                 Console.WriteLine(res);
//                 return res;
//             });
//         }
//     }
// }
