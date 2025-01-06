// namespace UsingKeyword
// {
//     // Some instances, for example StreamWriter instance needs to be closed after usage so that it doesn't keep it's stream busy. instead of that using keyword can be used to dispose of instance after the scope it's defined in ends.
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             using StreamWriter sw = new("./test.txt");
//             sw.WriteLine("First line");
//             sw.WriteLine("Second line");
//             sw.WriteLine("Third line");
//             sw.WriteLine("Fourth line");
//             sw.WriteLine("Fifthline");
//             // Instead of .Close() we use using above.
//             // sw.Close();
//         }
//     };
// }
