// using System;

// namespace Destructors
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person person = new();
//         }
//     };


//     class Person
//     {
//         public DateTime Born { get; set; }

//         public Person()
//         {
//             Born = DateTime.Now;
//             Console.WriteLine($"Person was born on - {Born.ToLongDateString()}");
//         }

//         // A destructor - this will run when gargabe collection disposes of Person instance
//         ~Person()
//         {
//             DateTime diedOn = DateTime.Now;

//             Console.WriteLine($"Person died on - {diedOn.ToLongDateString}");

//             Console.WriteLine("Person lived for - ");

//             TimeSpan livedTotal = Born - diedOn;

//             Console.WriteLine(livedTotal.TotalSeconds);
//         }
//     }
// }
