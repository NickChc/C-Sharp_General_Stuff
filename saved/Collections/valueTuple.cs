// namespace Tuples
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var ronaldo = (playerNo: 7, name: "Ronaldo", goals: 60);
//             var giggs = (playerNo: 10, name: "Giggs", goals: 40);

//             // DisplayInfo(ronaldo);
//             // DisplayInfo(giggs);
//             DisplayInfo(DisplayInfo());

//             // var ronaldoGoals = (year2017: 50, year2018: 40, year2019: 30);
//             // var ronaldo = (playerNo: 7, name: "Ronaldo", goals: ronaldoGoals);

//             // (int playerNumber, string name, int goals) ronaldo = (7, "Ronaldo", 55);
//             //
//             // Console.WriteLine(ronaldo.playerNumber);
//             // Console.WriteLine(ronaldo.name);
//             // Console.WriteLine(ronaldo.goals);
//             // Console.WriteLine();
//             //
//             // var messi = (playerNumber: 10, name: "Messi", goals: 60);
//             //
//             // Console.WriteLine(messi.playerNumber);
//             // Console.WriteLine(messi.name);
//             // Console.WriteLine(messi.goals);
//         }

//         public static void DisplayInfo((int playerNo, string name, int goals) player)
//         {
//             Console.WriteLine(player.playerNo);
//             Console.WriteLine(player.name);
//             Console.WriteLine(player.goals);
//         }

//         public static (int, string, int) DisplayInfo()
//         {
//             var messi = (playerNo: 10, name: "Messi", goals: 72);

//             return messi;
//         }
//     }
// }
