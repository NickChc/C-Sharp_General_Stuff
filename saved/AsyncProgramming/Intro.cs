// namespace AsyncProgramming
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Task task = new(SayHi);
//             task.Start();

//             Task task2 = new(() =>
//             {
//                 Console.WriteLine("Task 2 is starting.");
//                 Console.WriteLine("Task 2 is running.");
//                 Console.WriteLine("\nHI THERE FROM 2\n");

//                 Thread.Sleep(1500);
//                 Console.WriteLine("Task 2 has ended.");
//             });

//             task2.Start();

//             Task task3 = new(() =>
//             {
//                 Console.WriteLine("Task 3 is starting.");
//                 Console.WriteLine("Task 3 is running.");
//                 Console.WriteLine("\nHI THERE FROM 3\n");

//                 Thread.Sleep(1500);
//                 Console.WriteLine("Task 3 has ended.");
//             });

//             Console.WriteLine("What's you name?");
//             string name = Console.ReadLine() ?? "Unkown";
//             Console.WriteLine($"Hello, {name}");
//         }

//         public static void SayHi()
//         {
//             Console.WriteLine("Task 1 is starting.");
//             Console.WriteLine("Task 1 is running.");
//             Console.WriteLine("\nHI THERE FROM 1\n");

//             Thread.Sleep(1500);
//             Console.WriteLine("Task 1 has ended.");
//         }
//     }
// }
