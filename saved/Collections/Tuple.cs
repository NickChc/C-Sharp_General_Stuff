// namespace Tuples
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var info = GetInfo();

//             Console.WriteLine(info.Item1);
//             Console.WriteLine(info.Item2);
//             Console.WriteLine(info.Item3);
//             Console.WriteLine(info.Item4);

//             // Tuple<int, string, string, string> aria = Tuple.Create(
//             //     12,
//             //     "Aria",
//             //     "Stark",
//             //     "Winterfell"
//             // );
//             // Tuple<int, string, string, string> sansa = Tuple.Create(
//             //     16,
//             //     "Sansa",
//             //     "Stark",
//             //     "Winterfell"
//             // );

//             // DisplayInfo(aria);
//             // DisplayInfo(sansa);

//             // Tuple<
//             //     int,
//             //     string,
//             //     string,
//             //     string,
//             //     string,
//             //     string,
//             //     Tuple<decimal, decimal, decimal, decimal>
//             // > employeeInfo = new(
//             //     1,
//             //     "one",
//             //     "two",
//             //     "three",
//             //     "four",
//             //     "five",
//             //     Tuple.Create(1m, 2m, 3m, 420m)
//             // );

//             // Console.WriteLine(employeeInfo.Item7.Item4);

//             // Tuple<int, string, string, DateTime, bool> empInfo = new(
//             //     1,
//             //     "hello",
//             //     "mofo",
//             //     DateTime.Now,
//             //     false
//             // );

//             // var studentInfo = Tuple.Create(5, "Dave", "McClain", new DateTime(2003, 07, 26));
//             // Console.WriteLine(studentInfo.Item4.ToLongDateString());
//         }

//         public static void DisplayInfo(Tuple<int, string, string, string> personInfo)
//         {
//             Console.WriteLine(personInfo.Item1);
//             Console.WriteLine(personInfo.Item2);
//             Console.WriteLine(personInfo.Item3);
//             Console.WriteLine(personInfo.Item4);
//         }

//         public static Tuple<int, string, string, string> GetInfo()
//         {
//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("Age - ");
//             Console.ForegroundColor = ConsoleColor.White;
//             int age = int.Parse(Console.ReadLine() ?? "0");

//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("Name - ");
//             Console.ForegroundColor = ConsoleColor.White;
//             string name = Console.ReadLine() ?? "";

//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("Family Name - ");
//             Console.ForegroundColor = ConsoleColor.White;
//             string familyName = Console.ReadLine() ?? "";

//             Console.ForegroundColor = ConsoleColor.Green;
//             Console.WriteLine("Origin - ");
//             Console.ForegroundColor = ConsoleColor.White;
//             string origin = Console.ReadLine() ?? "";

//             return Tuple.Create(age, name, familyName, origin);
//         }
//     }
// }
