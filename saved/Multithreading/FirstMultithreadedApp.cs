// namespace FirstMultithreadedApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Thread t1 = new(new ThreadStart(SayHiEnglish)) { Name = "Thread Number 1 (English)" };
//             t1.Start();

//             Thread t2 = new(new ThreadStart(SayHiSpanish)) { Name = "Thread Number 2 (Spanish)" };
//             t2.Start();
//         }

//         private static void ThreadMessage()
//         {
//             Console.WriteLine($"Starting to execute - {Thread.CurrentThread.Name}");
//         }

//         public static void SayHiEnglish()
//         {
//             ThreadMessage();
//             for (int i = 0; i < 50; i++)
//             {
//                 Console.WriteLine("Hello...");
//             }
//         }

//         public static void SayHiSpanish()
//         {
//             ThreadMessage();
//             for (int i = 0; i < 50; i++)
//             {
//                 Console.WriteLine("Hola...");
//             }
//         }
//     }
// }
