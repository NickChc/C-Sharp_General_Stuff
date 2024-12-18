// namespace DeadLocksAndLockKeyword // Lock
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Files file = new();

//             Thread[] threads = new Thread[10];

//             for (int i = 0; i < threads.Length; i++)
//             {
//                 threads[i] = new(new ParameterizedThreadStart(file.Write!));
//                 threads[i].Start($"C:\\accounts{i}.txt");
//             }
//         }
//     }

//     class Files
//     {
//         public object thisLock = new();

//         public void Write(object path)
//         {
//             lock (thisLock)
//             {
//                 Console.WriteLine("Writing in - " + path);
//                 Thread.Sleep(2000);
//                 Console.WriteLine("Writing process has been completed");
//             }
//         }

//         public void Read(object path)
//         {
//             lock (thisLock)
//             {
//                 Console.WriteLine("Reading from - " + path);
//                 Thread.Sleep(1000);
//                 Console.WriteLine("Reading process has been completed");
//             }
//         }
//     }
// }
