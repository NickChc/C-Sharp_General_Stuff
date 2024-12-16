// using System.Timers;

// namespace TimerNamespace
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Timers.Timer timer = new();
//             timer.Elapsed += OnEachSecond;
//             timer.Interval = 1000;
//             timer.Enabled = true;

//             Console.WriteLine("Press (x) to exit");

//             while (Console.ReadLine() != "x") { }
//         }

//         private static void OnEachSecond(object sender, ElapsedEventArgs e)
//         {
//             Console.WriteLine($"Working. TIME - {DateTime.Now.ToShortTimeString()} ");
//         }
//     }
// }
