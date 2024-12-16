// namespace ExpressionBodiedMembers
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int res = AddTwoNumbersFaster(5, 10);

//             Console.WriteLine(res);
//         }

//         // Expression bodied members
//         public static int AddTwoNumbersFaster(int x, int y) => x + y;

//         public static void SayHi(string name) => Console.WriteLine($"Hello, {name}");

//         public static Action askAboutAge = () =>
//         {
//             Console.WriteLine("How old are you?");
//         };

//         public static Action<string, string> sayHi = (string password, string name) =>
//         {
//             if (password == "Password" && name == "Admin")
//             {
//                 Console.WriteLine("GOOD");
//             }

//             Console.WriteLine("BAD");
//         };

//         public static int AddTwoNumbers(int x, int y)
//         {
//             return x + y;
//         }
//     }

//     class Animal(string name)
//     {
//         private string _name = name ?? "Unkown";
//         public string Name
//         {
//             get => _name;
//             set => _name = value;
//         }
//     }
// }
