// namespace TaskWithParams
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Task task1 = Task.Run(() => SayHi("Dave"));

//             Task task2 = new(
//                 delegate(object? name)
//                 {
//                     Console.WriteLine(name);
//                 },
//                 "Dave"
//             );

//             Task task3 = new(
//                 (object? name) =>
//                 {
//                     Console.WriteLine($"Hi, {name}");
//                 },
//                 "Jack"
//             );

//             Console.ReadLine();
//         }

//         public static void SayHi(object name)
//         {
//             Console.WriteLine($"Welcome back, {name}");
//         }
//     }
// }
