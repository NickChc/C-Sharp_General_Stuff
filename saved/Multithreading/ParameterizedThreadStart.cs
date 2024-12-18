// namespace ParameterizedThreadStartLesson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Helper helper = new();

//             Thread t1 = new(new ParameterizedThreadStart(helper.Loop));

//             t1.Start(100);
//         }
//     }

//     class Helper
//     {
//         public void Loop(object? number)
//         {
//             for (int i = 0; i < int.Parse(number?.ToString() ?? "10"); i++)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }
