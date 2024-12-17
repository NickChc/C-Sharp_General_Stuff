// // TODO : continue from video - 177
// using System.Reflection;

// namespace Assignments_16_to_18
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             MyMath.PerformOps(15, 25);
//         }
//     }

//     // Assignment 16
//     class DirAgent
//     {
//         public static void SearchForDirsWithPattern(string path)
//         {
//             if (!Directory.Exists(path))
//             {
//                 return;
//             }

//             var matchedFiles = Directory.GetFiles(path, "*.txt");

//             foreach (var filepath in matchedFiles)
//             {
//                 FileInfo file = new(filepath);

//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 Console.WriteLine($"{file.Name} matched chosen format of .txt");
//                 Console.ResetColor();
//             }
//         }

//         public static void ListDirs(string path, int depth = 0)
//         {
//             Console.WriteLine();
//             if (Directory.Exists(path))
//             {
//                 DirectoryInfo dirInfo = new(path);

//                 string spaces = new(' ', depth * 4);

//                 Console.ForegroundColor = ConsoleColor.Green;
//                 Console.WriteLine($"{spaces}{dirInfo.Name}\\");
//                 Console.ResetColor();

//                 var files = Directory.GetFiles(dirInfo.FullName);

//                 Console.ForegroundColor = ConsoleColor.Blue;
//                 foreach (var filepath in files)
//                 {
//                     FileInfo file = new(filepath);
//                     string formattedDate = string.Format(
//                         "{0:dd/mm/yyyy hh:mm:ss}",
//                         file.CreationTime
//                     );

//                     Console.WriteLine($"{spaces}{file.Name} - created at - ({formattedDate})");
//                 }
//                 Console.ResetColor();

//                 var subDirs = Directory.GetDirectories(path);

//                 foreach (string dir in subDirs)
//                 {
//                     ListDirs(dir, depth + 1);
//                 }
//             }
//         }
//     }

//     // Assignment 17

//     static class CustomExtensions
//     {
//         public static string CapitalizeFirstLetter(this string value)
//         {
//             return value[0].ToString().ToUpper() + value[1..];
//         }

//         public static string Capitalize(this string value)
//         {
//             return value.ToUpper();
//         }

//         public static string CapitalizeSentence(this string value)
//         {
//             string[] words = value.Split(' ');

//             for (int i = 0; i < words.Length; i++)
//             {
//                 words[i] = words[i].CapitalizeFirstLetter();
//             }

//             return string.Join(' ', words);
//         }
//     }

//     // Assignment 18
//     public delegate void MathDel(int x, int y);

//     class MyMath
//     {
//         public static void PerformOps(int x, int y)
//         {
//             MathDel mathOps = new((int x, int y) => Console.WriteLine(x - y));
//             mathOps += new MathDel((int x, int y) => Console.WriteLine(x + y));
//             mathOps += new MathDel((int x, int y) => Console.WriteLine(x / y));
//             mathOps += new MathDel((int x, int y) => Console.WriteLine(x * y));
//             mathOps += new MathDel((int x, int y) => Console.WriteLine(x % y));

//             mathOps(x, y);
//         }
//     }
// }
