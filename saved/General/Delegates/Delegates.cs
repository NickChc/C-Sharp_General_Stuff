// namespace Delegates
// {
//     // player info with name and goals args
//     public delegate void PlayerInfoWithGoals(string name, int goals);

//     // player info with int and string args
//     public delegate void PlayerInfoBasedOnNumberAndClub(
//         int number,
//         string club,
//         string country = "Unkown"
//     );

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             PlayerInfoWithGoals ronaldo = new(GetPlayerInfo);
//             // ronaldo("Ronaldo", 50);

//             PlayerInfoBasedOnNumberAndClub messi = new(GetPlayerInfo);
//             // messi(10, "Barcelonna FC", "Portugal");

//             // Console.WriteLine(ronaldo.Method);


//             foreach (var param in messi.Method.GetParameters())
//             {
//                 Console.WriteLine(
//                     $"param {param.Name} of type {param.ParameterType.Name} at position {param.Position}"
//                 );
//                 bool isOptional = param.IsOptional;
//                 Console.WriteLine($"Is it optional - ");
//             }
//         }

//         public static void GetPlayerInfo(string name, int goals)
//         {
//             Console.WriteLine($"Info about player - NAME: {name} - GOALS: {goals}");
//         }

//         public static void GetPlayerInfo(int number, string club, string country = "Unknown")
//         {
//             Console.WriteLine(
//                 $"Player info: No. - {number}, \n Club - {club}, Country - {country} "
//             );
//         }
//     }
// }



// MORE HERE



// namespace Delegates
// {
//     // void delegate with no args
//     public delegate void PersonInfoDel();

//     // void delegate with name arg
//     public delegate void PersonInfoWithNameDel(string name);

//     // void delegate with name and age args
//     public delegate void PersonInfoWithNameAndAgeDel(string name, int age);

//     // string delegate with age arg
//     public delegate string PersonInfoWithAgeDel(int age);

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             PersonInfoDel me = new(GetInfo);
//             // me();

//             PersonInfoWithNameDel dave = new(GetInfo);
//             // dave("Dave");

//             PersonInfoWithNameAndAgeDel mike = new(GetInfo);
//             // mike("Mike", 42);

//             PersonInfoWithAgeDel person = new(GetInfo);
//             Console.WriteLine(person(21));
//         }

//         public static void GetInfo()
//         {
//             Console.WriteLine("No player provided");
//         }

//         public static void GetInfo(string name)
//         {
//             Console.WriteLine(name);
//         }

//         public static void GetInfo(string name, int age)
//         {
//             Console.WriteLine($"{name} is {age} years old.");
//         }

//         public static string GetInfo(int age)
//         {
//             string person = age switch
//             {
//                 21 => "Me",
//                 15 => "Dave",
//                 42 => "Mike",
//                 _ => "Unknown",
//             };

//             return person;
//         }
//     }
// }
