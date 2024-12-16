// namespace GenericDictionary
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating
//             Dictionary<string, string> capitals = [];

//             capitals.Add("Georgia", "Tbilisi");
//             capitals.Add("USA", "Washington");
//             capitals.Add("England", "London");
//             capitals.Add("Italy", "Rome");

//             // Creating with initialization
//             Dictionary<int, string> dict = new()
//             {
//                 { 0, "one" },
//                 { 1, "two" },
//                 { 2, "three" },
//             };

//             capitals.TryGetValue("England", out string capitalOfEngland);

//             Console.WriteLine(capitalOfEngland);

//             capitals.Remove("England");

//             foreach (var item in capitals)
//             {
//                 Console.WriteLine(item);
//             }

//             Dictionary<object, object> person = new()
//             {
//                 { "name", "Dave" },
//                 { "age", 21 },
//                 { "occupation", "Programmer" },
//             };
//         }
//     }
// }
