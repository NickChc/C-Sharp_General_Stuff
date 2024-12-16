// PARAMS KEYWORD --------------------------
// namespace RecursiveMethods
// {
//     // VIDEO 149
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             LoopThroughArray(
//                 name: "An array of man's names",
//                 "Dave",
//                 "Mike",
//                 "Jake",
//                 "Jim",
//                 "Rick"
//             );
//             Console.WriteLine("\n=============================\n");
//             LoopThroughArray(name: "An array of girl's names", "Sally", "Donna", "Laguerta");
//         }

//         static void LoopThroughArray(string name, params string[] array)
//         {
//             Console.WriteLine(name + "\n");

//             foreach (string item in array)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }
