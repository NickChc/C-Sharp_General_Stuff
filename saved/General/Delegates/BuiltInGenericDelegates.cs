// namespace BuiltInGenericDelegates
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Func<int, int, int> funcOne = AddTwoNumbers;

//             Func<int> funcTwo = AddTwoNumbers;

//             Console.WriteLine(funcOne(2, 4));
//             Console.WriteLine(funcTwo());
//         }

//         public static int AddTwoNumbers(int x, int y)
//         {
//             return x + y;
//         }

//         public static int AddTwoNumbers()
//         {
//             int z = 0;
//             int x = 5;
//             int y = 8;

//             z = x + y;

//             return z;
//         }
//     }
// }
