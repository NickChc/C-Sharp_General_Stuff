// namespace KeyvaluePair
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             KeyValuePair<string, string> table = new("ID", "dewijacndind");

//             var capitals = new List<KeyValuePair<string, string>>()
//             {
//                 { new("Georgia", "Tbilisi") },
//                 { new("Sweden", "Stockholm") },
//                 { new("Japan", "Tokyo") },
//             };

//             capitals.Add(new("Germany", "Berlin"));

//             capitals.RemoveAt(0);

//             foreach (KeyValuePair<string, string> item in capitals)
//             {
//                 Console.WriteLine(item);
//             }

//             KeyValuePair<string, string> pair = ReturnKeyAndValue();

//             Console.WriteLine(pair.Key);
//         }

//         public static KeyValuePair<string, string> ReturnKeyAndValue()
//         {
//             string firstname = "Nick";
//             string lastname = "Chichua";

//             return new(firstname, lastname);
//         }
//     }
// }
