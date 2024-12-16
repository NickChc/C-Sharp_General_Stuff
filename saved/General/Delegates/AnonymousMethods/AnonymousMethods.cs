// namespace AnonymousMethods
// {
//     public delegate void DisplayInfoDel();
//     public delegate void DisplayInfoWithParamDel(int number);

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DisplayInfoDel normalDelegate = new(DisplayInfo);
//             normalDelegate();

//             DisplayInfoWithParamDel withparamDelegate = new(DisplayInfo);
//             withparamDelegate(5);

//             Console.WriteLine("=====================");

//             DisplayInfoDel normalDelegateAnonymous = delegate
//             {
//                 Console.WriteLine("Hi from the anonymous method");
//             };
//             normalDelegateAnonymous();

//             DisplayInfoWithParamDel displayInfoWithNumberAnonymous = delegate(int number)
//             {
//                 Console.WriteLine($"Hi from the anonymous method with param - {number}");
//             };
//             displayInfoWithNumberAnonymous(200);
//         }

//         public static void DisplayInfo()
//         {
//             Console.WriteLine("No params display info");
//         }

//         public static void DisplayInfo(int number)
//         {
//             Console.WriteLine($"display info with int param {number}");
//         }
//     }
// }
