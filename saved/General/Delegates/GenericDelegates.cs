// namespace DelegateMulticast
// {
//     public delegate T DisplayInfoDel<T>(T value);

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DisplayInfoDel<int> myNumber = new(DisplayInfo);

//             myNumber(100);

//             DisplayInfoDel<string> myString = new(DisplayInfo);

//             myString("Hello there");

//             DisplayInfoDel<DateTime> myDate = new(DisplayInfo);

//             myDate(DateTime.Now);
//         }

//         public static T DisplayInfo<T>(T value)
//         {
//             Console.WriteLine($"Accessing a variable of type - {value?.GetType().Name}");
//             return value;
//         }
//     }
// }
