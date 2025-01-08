// using System.Security.Cryptography.X509Certificates;

// namespace PatternMatchingLesson
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Dog dag = new();
//             Cat cat = new();
//             Lion lion = new();

//             AnimalSound(dag);
//         }

//         // Using IS
//         public static void AnimalSound(object animal)
//         {
//             if (animal is Dog)
//             {
//                 Console.WriteLine("Woof");
//             }
//             else if (animal is Cat)
//             {
//                 Console.WriteLine("Meow");
//             }
//             else if (animal is Lion)
//             {
//                 Console.WriteLine("Roar");
//             }
//             else
//             {
//                 Console.WriteLine("Unknown animal");
//             }
//         }

//         // Using SWITCH
//         public static void AnimalSoundSwitch(object animal)
//         {
//             switch (animal)
//             {
//                 case Dog:
//                     Console.WriteLine("Woof");
//                     break;
//                 case Cat:
//                     Console.WriteLine("Meow");
//                     break;
//                 default:
//                     Console.WriteLine("Unknown animal");
//                     break;
//             }
//         }

//         // Using SWITCH and WHEN
//         public static void AnimalSoundWithSwitchAndWhen(object animal)
//         {
//             switch (animal)
//             {
//                 case Dog d when d.DogName == "Unknown":
//                     Console.WriteLine("Name not set");
//                     break;
//                 default:
//                     Console.WriteLine("Unknown anima;");
//                     break;
//             }
//         }
//     };

//     class Cat
//     {
//         public string CatSound { get; set; } = "Unkown";
//         public string CatName { get; set; } = "Unkown";
//     }

//     class Dog
//     {
//         public string DogSound { get; set; } = "Unkown";
//         public string DogName { get; set; } = "Unkown";
//     }

//     class Lion
//     {
//         public string LionSound { get; set; } = "Unkown";
//         public string LionName { get; set; } = "Unkown";
//     }
// }
