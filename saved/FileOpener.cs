// using System.Diagnostics;

// namespace Lesson
// {
//     class Program
//     {
//         static async Task Main(string[] args)
//         {
//             string path = "./TEST.txt";

//             string content =
//                 "Some pretty big text\n I also wanna test if string escape characters work here. It's actually already visibly working, but still...";

//             await CreateAndOpen(path, content);

//             OpenFile(path);
//         }

//         public static async Task CreateAndOpen(string path, string content)
//         {
//             try
//             {
//                 using (StreamWriter sw = new(path))
//                 {
//                     await sw.WriteLineAsync(content);
//                     await sw.FlushAsync();
//                 }
//                 using StreamReader sr = new(path);
//                 string result = sr.ReadToEnd();
//                 Console.WriteLine(result);
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Failed to read file - {ex.Message}");
//             }
//         }

//         public static void OpenFile(string path)
//         {
//             try
//             {
//                 if (File.Exists(path))
//                 {
//                     FileInfo file = new(path);
//                     // opens file in vs code new tab
//                     // Process.Start(
//                     // new ProcessStartInfo
//                     // {
//                     // FileName = "code",
//                     // Arguments = file.FullName,
//                     // UseShellExecute = true,
//                     // }
//                     // );

//                     // Open a file in it's default environment (notepad in this case)
//                     Process.Start(
//                         new ProcessStartInfo { FileName = file.FullName, UseShellExecute = true }
//                     );

//                     return;
//                 }

//                 Console.WriteLine("File Not Found");
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"failed opening file - {path} \n {ex.Message}");
//             }
//         }

//         public static Task<object> Waiter(int time)
//         {
//             TaskCompletionSource<object> tcs = new();

//             System.Threading.Timer timer = new(
//                 (_) =>
//                 {
//                     tcs.SetResult(null!);
//                 },
//                 null,
//                 time,
//                 Timeout.Infinite
//             );

//             return tcs.Task;
//         }
//     };
// }
