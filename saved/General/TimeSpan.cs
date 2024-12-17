// using System.Runtime;

// namespace TimeSpanLesson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // TimeSpan timeSpan = new(10, 08, 65); // 10:09:05
//             TimeSpan timeSpan = new(1, 26, 08, 65);

//             Console.WriteLine(timeSpan);

//             timeSpan = timeSpan.Add(new(0, 0, 30));

//             Console.WriteLine(timeSpan);

//             DateTime dateOne,
//                 dateTwo;

//             dateOne = new(1999, 10, 30);
//             dateTwo = new(2017, 10, 30);

//             TimeSpan res = dateTwo - dateOne;
//             res = dateTwo.Subtract(dateOne);
//             Console.WriteLine(res.TotalDays / 365.25);
//         }
//     }
// }
