// using System.Text;

// namespace StringBuilderLesson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             StringBuilder builder = new(10, 16);
//             builder.Append(" Dave o");
//             builder.AppendLine(".");
//             // builder.AppendLine(DateTime.Now.ToShortTimeString());
//             builder.Append('?');

//             builder.Insert(0, "Hello");

//             // builder.Replace('o', '0');
//             builder.Replace('o', '0', 0, 4);

//             Console.WriteLine(builder);

//             builder.Remove(0, 5);
//             // builder.Append(" a bit too long ain't it?"); throws an error


//             Console.WriteLine(builder);
//         }
//     };
// }
