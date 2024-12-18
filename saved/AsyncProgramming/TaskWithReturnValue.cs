// namespace TaskWithReturnValue
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Task<int> task = new(() =>
//             {
//                 int res = 0;

//                 for (int i = 0; i <= 5; i++)
//                 {
//                     Console.WriteLine(i);
//                     res += i;
//                 }

//                 return res;
//             });

//             task.Start();
//             Console.WriteLine(task.Result);

//             Console.ReadLine();
//         }
//     }
// }
