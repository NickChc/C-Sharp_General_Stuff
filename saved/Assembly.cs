// using System.Globalization;
// using System.Reflection;

// namespace AssemblyAndCultureInfoLesson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Assembly assemObj = Assembly.GetEntryAssembly()!;
//             AssemblyName assemName = assemObj.GetName();

//             Console.WriteLine(assemObj.FullName);

//             // CultureInfo class
//             CultureInfo cultureInfo = new("ka-GE");
//             assemName.CultureInfo = cultureInfo;
//             Console.WriteLine(assemName.CultureInfo.NativeName);
//             Console.WriteLine(assemName.CultureInfo.NumberFormat.CurrencySymbol);
//             Console.WriteLine(assemName.CultureInfo.Calendar);

//             // Versions
//             // 1.0.4.3 - Major.Minor.Build.Revision

//             assemName.Version = new(1, 3, 1, 3);
//             Console.WriteLine(assemName.Version);
//         }
//     };
// }
