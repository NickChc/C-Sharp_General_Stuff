// // Predicate delegate is the same as Action and Func delegates. But it must take one input parameter and return a boolean value


// namespace GenericDelegatePredicate
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Predicate<int> condition = IsAdmin;

//             Console.WriteLine(condition(11)); // False
//             Console.WriteLine(condition(10)); // True
//         }

//         public static bool IsAdmin(int empNo)
//         {
//             if (empNo == 10)
//             {
//                 return true;
//             }

//             return false;
//         }
//     }
// }
