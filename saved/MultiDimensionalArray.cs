// namespace MultiDimensionalArrayLessson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // string[,] array2D = new string[2, 3];
//             // array2D[0, 0] = "item 00";
//             // array2D[0, 1] = "item 01";

//             // array2D[1, 0] = "item 10";
//             // array2D[1, 1] = "item 11";

//             // array2D[2, 0] = "";
//             // array2D[2, 1] = "";

//             // string[,] array2DA = new string[2, 2]
//             // {
//             //     { "name", "Dave" },
//             //     { "surname", "Smith" },
//             // };

//             int[,] numbersArray = new int[,]
//             {
//                 { 1, 2 },
//                 { 3, 4 },
//                 { 5, 6 },
//             };

//             for (int i = 0; i < 3; i++)
//             {
//                 Console.WriteLine($"Accessing ROW - {i}");

//                 for (int j = 0; j < 2; j++)
//                 {
//                     Console.WriteLine($"Accessing COLUMN - {j}");
//                     Console.WriteLine(numbersArray[i, j]);
//                 }
//             }

//             // Must throw exception (Index was outside of array boundary)
//             // array2D[3, 1] = "";
//             // array2D[2, 2] = "";
//         }
//     };
// }
