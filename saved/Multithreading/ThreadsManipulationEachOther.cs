// namespace ThreadsManipulatingEachOther
// {
//     class Program
//     {
//         static Thread? t1;
//         static Thread? t2;

//         static void Main(string[] args)
//         {
//             t1 = new(new ThreadStart(SayHiEnglish)) { Name = "Thread Number 1 (English)" };
//             t1.Start();

//             t2 = new(new ThreadStart(SayHiSpanish)) { Name = "Thread Number 2 (Spanish)" };
//             t2.Start();
//         }

//         private static void ThreadMessage()
//         {
//             Console.WriteLine($"Starting to execute - {Thread.CurrentThread.Name}");
//         }

//         public static void SayHiEnglish()
//         {
//             // t2?.Join();
//             ThreadMessage();
//             for (int i = 0; i < 50; i++)
//             {
//                 // if (i == 31)
//                 // {
//                 //     Console.WriteLine("THREAD ABORTED");
//                 //     // t1.Abort(); // Not recommended, will cause warnings / errors
//                 // }
//                 // Thread.Sleep(1000);
//                 // Thread.Sleep(new TimeSpan(0, 0, 1));
//                 Console.WriteLine(i + " Hello...");
//             }
//         }

//         public static void SayHiSpanish()
//         {
//             t1?.Join();
//             ThreadMessage();
//             for (int i = 0; i < 50; i++)
//             {
//                 Console.WriteLine(i + " Hola...");
//             }
//         }
//     }
// }
