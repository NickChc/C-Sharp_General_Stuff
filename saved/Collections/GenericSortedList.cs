// using System.Collections;

// namespace GenericSortedList
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating
//             SortedList<string, string> phoneBook = new() { { "Placeholder", "555443322" } };

//             // Adding
//             phoneBook.Add("Me", "555158001");
//             phoneBook.Add("Jake", "599209163");
//             phoneBook.Add("Dad", "599576773");
//             phoneBook.Add("Mom", "577557667");

//             // TryGetValue
//             // phoneBook.TryGetValue("Jake", out string jakeNumber);
//             // Console.WriteLine(jakeNumber);

//             // Removing
//             phoneBook.Remove("Placeholder");

//             // Displaying
//             foreach (var (Key, Value) in phoneBook)
//             {
//                 Console.WriteLine($"{Key} - {Value}");
//             }

//             Console.WriteLine(phoneBook.ContainsKey("Gio"));
//             Console.WriteLine(phoneBook.ContainsValue("555158001"));
//         }
//     }
// }
