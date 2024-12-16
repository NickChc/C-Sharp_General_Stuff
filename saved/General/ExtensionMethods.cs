// namespace ExtensionMethods
// {
//     // VIDEO 149
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // int x = default;
//             // Console.WriteLine(x.IsGreater(10));

//             // string test = "Test string";
//             // test.Log();

//             // string test = "23.32";
//             // Console.WriteLine(test.IsNumber()); // Returns False
//         }
//     }

//     static class CustomExtension
//     {
//         public static bool IsGreater(this int value, int n)
//         {
//             return value > n;
//         }

//         public static void Log(this string value)
//         {
//             Console.WriteLine(value);
//         }

//         public static bool IsNumber(this string value)
//         {
//             return int.TryParse(value, out int _);
//         }
//     }
// }
