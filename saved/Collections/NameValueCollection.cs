// using System.Collections.Specialized;

// namespace NameValueCollectionApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Creating
//             NameValueCollection cities = new()
//             {
//                 { "USA", "Washington" },
//                 { "Georgia", "Tbilisi" },
//                 { "Georgia", "Qutaisi" },
//                 { "Italy", "Rome" },
//             };

//             cities.Add("Turkey", "Ankara");

//             // Set
//             cities.Set("Italy", "Sicilia");

//             // Has
//             Console.WriteLine(cities.HasKeys());

//             // Remove
//             cities.Remove("Georgia");

//             foreach (string city in cities)
//             {
//                 Console.WriteLine($"{city} - {cities[city]}");
//             }
//         }
//     }
// }
