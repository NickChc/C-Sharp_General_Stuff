// using System.Collections;

// namespace BitArrayTest
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating
//             bool[] boolArr = [false, false, true, false];

//             BitArray firstArr = new(4);

//             BitArray secondArr = new(boolArr);

//             // Setting value
//             firstArr.Set(3, true);

//             // And - Or - Not
//             BitArray result = new((BitArray)firstArr.Clone());
//             result.Not();

//             Console.WriteLine();

//             LogArray(firstArr);

//             Console.WriteLine();

//             LogArray(result);
//         }

//         static void LogArray(BitArray collection)
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             foreach (var item in collection)
//             {
//                 Console.WriteLine(item);
//             }
//             Console.ResetColor();
//         }
//     }
// }
