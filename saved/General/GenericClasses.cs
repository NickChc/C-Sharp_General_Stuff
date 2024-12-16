// using System.Collections;

// namespace GenericClass
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Movie<float, DateTime> LOTR1 = new(
//                 "The lord of the rings",
//                 "Who knows",
//                 9.8f,
//                 new(2002, 08, 22)
//             );
//             Movie<float, DateTime> LOTR2 = new(
//                 "The lord of the rings 2",
//                 "Who knows",
//                 9.5f,
//                 new(2004, 02, 22)
//             );
//             Movie<float, DateTime> LOTR3 = new(
//                 "The lord of the rings 3",
//                 "Who knows",
//                 9.0f,
//                 new(2005, 04, 22)
//             );

//             List<Movie<float, DateTime>> movies = [LOTR1, LOTR2, LOTR3];

//             Movie<double, int> darkKnight = new("The dark knight", "Christopher Nolan", 9.2d, 1998);
//             Movie<double, int> darkKnight2 = new(
//                 "The dark knight rises",
//                 "Christopher Nolan",
//                 8.8d,
//                 2002
//             );
//             Movie<double, int> darkKnight3 = new(
//                 "The dark knight falls",
//                 "Christopher Nolan",
//                 6.0d,
//                 2005
//             );

//             List<Movie<double, int>> batmanMovies = [darkKnight, darkKnight2, darkKnight3];

//             ArrayList array = [LOTR1, darkKnight2];

//             foreach (var item in array)
//             {
//                 if (item is Movie<float, DateTime> movie)
//                 {
//                     movie.GetInfo();
//                 }
//                 else if (item is Movie<double, int> movei2)
//                 {
//                     movei2.GetInfo();
//                 }
//                 else
//                 {
//                     Console.WriteLine("FAIL");
//                 }
//             }
//         }
//     }

//     class Movie<T, U>(string name, string director, T rate, U releaseDate)
//     {
//         public string Name { get; set; } = name ?? "Unknown";
//         public string Director { get; set; } = director ?? "Unknown";
//         public T Rate { get; set; } = rate;
//         public U ReleaseDate { get; set; } = releaseDate;

//         public void GetInfo()
//         {
//             Console.WriteLine(
//                 $"NAME - {Name} \nDIRECTOR - {Director} \nRATE - {Rate} \nRELEASE DATE - {ReleaseDate}"
//             );
//         }
//     }
// }
