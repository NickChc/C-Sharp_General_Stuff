// namespace LambdaExpressions
// {
//     public delegate List<int> FilterArray(List<int> arr);

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//             List<int> oddArray = array.Where((n) => n % 2 != 0).ToList();
//             List<int> evenArray = array.Where((n) => n % 2 == 0).ToList();

//             List<int> oddWithoutThree = oddArray
//                 .Where(
//                     (n) =>
//                     {
//                         if (n == 3)
//                         {
//                             Console.WriteLine("This one is restricted");
//                             return false;
//                         }
//                         return true;
//                     }
//                 )
//                 .ToList();

//             foreach (var item in oddWithoutThree)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }
